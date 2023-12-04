using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Traveller.Domain;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Services;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelReservationController : ControllerBase
{
    private readonly Repositories _repositories;
    private readonly ExporterService _exporterService;

    private readonly ILogger<HotelReservationController> _logger;

    public HotelReservationController(ILogger<HotelReservationController> logger, Repositories repositories,
        ExporterService exporterService)
    {
        _logger = logger;
        _repositories = repositories;
        _exporterService = exporterService;
    }

    [HttpPost]
    [Authorize(Roles = ("Agent, Tourist"))]
    public async Task<ActionResult> Create(ReservationDto reservationDto)
    {
        if (reservationDto.NumberOfTravellers <= 0)
            return BadRequest("The number of travellers must be greater than 0");
            
        var offer = await _repositories.HotelOffers.FindById(reservationDto.OfferId);
        
        if (offer is null)
            return NotFound($"Hotel Offer id: {reservationDto.OfferId} doesn´t exists");
        
        var token = Request.Headers.Authorization[0]![7..];
        var jwt = new JwtSecurityToken(token);
            
        if (int.TryParse(jwt.Claims.First(c => c.Type == "agencyId").Value, out var agencyId)
            && agencyId != offer.AgencyId)
        {
            return Unauthorized("You don't have permission for this action");
        }

        if (offer.Capacity < reservationDto.NumberOfTravellers)
            return BadRequest(
                $"The offer doesn't have enough capacity for {reservationDto.NumberOfTravellers} travellers");

        offer.Capacity = (uint)(offer.Capacity - reservationDto.NumberOfTravellers);
        
        try
        {
            var reservation = new HotelReservation();
            var price = offer.Price * reservationDto.NumberOfTravellers;
            reservation.Price = price;
            var payment = reservationDto.GetPayment(price);
            ReservationDto.Map<Hotel, HotelReservation, HotelOffer>(reservation, reservationDto);
            await _repositories.Payment.AddAsync(payment);
            reservation.Payment = payment;
            await _repositories.HotelReservations.AddAsync(reservation);
            await _repositories.HotelReservations.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpPut("{id:int}")]
    [Authorize(Roles = ("Agent, Tourist"))]
    public async Task<ActionResult> Update([FromBody] ReservationDto reservationDto, [FromRoute] int id)
    {
        try
        {
            var dbHotelReservation = await _repositories.HotelReservations.FindById(id);
            if (dbHotelReservation is null)
                return NotFound($"Hotel Reservation with id {id} doesn't exist");

            var token = Request.Headers.Authorization[0]!.Substring(7);
            var jwt = new JwtSecurityToken(token);
            var role = jwt.Claims.First(c => c.Type == "role").Value;
            var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);


            if (role == "Tourist" && userId != dbHotelReservation.TouristId)
                return BadRequest($"Tourists can only change their own reservations");

            var offer = await _repositories.HotelOffers.FindById(dbHotelReservation.OfferId);

            if (role == "Agent")
            {
                var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

                if (agencyId != offer!.AgencyId)
                    return BadRequest("Agents can only change reservations for they own agency");
            }

            var oldPaymentId = dbHotelReservation.PaymentId; //no quiero que nadie pueda modificar el PaymentId
            var oldPrice = dbHotelReservation.Price; //ni el precio

            ReservationDto.Map<Hotel, HotelReservation, HotelOffer>(dbHotelReservation, reservationDto);
            dbHotelReservation.PaymentId = oldPaymentId;
            dbHotelReservation.Price = oldPrice;

            await _repositories.HotelReservations.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpDelete("{id:int}")]
    [Authorize(Roles = ("Agent, Tourist"))]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);

        try
        {
            var dbHotelReservation = await _repositories.HotelReservations.FindById(id);
            
            if (dbHotelReservation is null)
                return NotFound($"Hotel reservation with id {id} doesn't exist");
            
            if ((role == "Tourist") && (userId != dbHotelReservation.TouristId))
                return BadRequest($"Tourists can only delete their own reservations");

            var offer = await _repositories.HotelOffers.FindById(dbHotelReservation.OfferId);

            if (role == "Agent")
            {
                var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

                if (agencyId != offer!.AgencyId)
                    return BadRequest("Agents can only change reservations for they own agency");
            }

            await _repositories.Payment.Remove(dbHotelReservation.PaymentId);
            await _repositories.HotelReservations.Remove(id);
            await _repositories.Payment.SaveChangesAsync();
            await _repositories.HotelReservations.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    [Authorize(Roles = ("Agent, Tourist"))]
    public ActionResult<IEnumerable<ReservationDto>> GetAll([FromQuery] PaginationDto filter)
    {
        var token = Request.Headers.Authorization[0]![7..];
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);

        var items = _repositories.HotelReservations.FindWithInclude(f => f.Offer);

        if (role == "Tourist")
            items = items.Where(rsv => rsv.TouristId == userId);
        else
        {
            var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

            items = items.Where(rsv => rsv.Offer.AgencyId == agencyId);
        }

        if (filter.OrderBy != null)
        {
            switch (filter.OrderBy)
            {
                case ("Price"):
                    items = items.OrderBy(item => item.Price); break;
                case ("DepartureDay"):
                    items = items.OrderBy(item => item.DepartureDate); break;
                default:
                    items = items.OrderBy(item => item.Id); break;
            }
        }

        if (filter.Descending.HasValue && filter.Descending.Value)
            items = items.Reverse();

        var pageItems = (filter.PageIndex == null || filter.PageSize == null ? items : items.Take(new Range((filter.PageIndex.Value - 1) * filter.PageSize.Value, (filter.PageIndex.Value - 1) * filter.PageSize.Value + filter.PageSize.Value)))
                            .Select(ReservationDto.Map<Hotel, HotelReservation, HotelOffer>);

        return Ok(new PaginationResponse<ReservationDto>() { TotalCollectionSize = items.Count(), Items = pageItems });
    }

    [HttpGet("{id:int}")]
    [Authorize(Roles = "Agent, Tourist")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        var token = Request.Headers.Authorization[0]![7..];
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);

        try
        {
            var reservation = await _repositories.HotelReservations.FindById(id);

            if (reservation is null)
                return NotFound($"Hotel reservation with id {id} doesn't exist");

            if ((role == "Tourist") && (userId != reservation.TouristId))
                return BadRequest($"Tourists can only see their own reservations");

            if (role == "Agent")
            {
                var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

                var offer = await _repositories.HotelOffers.FindById(reservation.OfferId);

                if (agencyId != offer!.AgencyId)
                    return BadRequest("Agents can only see their own agency reservations");
            }

            return Ok(ReservationDto.Map<Hotel, HotelReservation, HotelOffer>(reservation));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet("getSales")]
    [Authorize(Roles = ("MarketingEmployee, Admin"))]
    public ActionResult GetSales([FromQuery] SalesRequest request, [FromQuery] ExportType? export)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        if (request.GroupBy == null)
            request.GroupBy = GroupBy.Day;

        IEnumerable<SalesResponse> response;

        switch (request.GroupBy)
        {
            case GroupBy.Day:
                response = _repositories.HotelReservations.FindWithInclude(reservation => reservation.Offer).Where(
                        reservation => reservation.Offer.AgencyId == agencyId &&
                                       DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start &&
                                       DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
                    .GroupBy(reservation => DateOnly.FromDateTime(reservation.ArrivalDate))
                    .OrderBy(group => group.Key)
                    .Select(group => new SalesResponse
                    {
                        Group = group.Key.ToString(), Total = group.Count(),
                        MoneyAmount = group.Sum(reservation => reservation.Price)
                    });
                break;
            case GroupBy.Year:
                response = _repositories.HotelReservations.FindWithInclude(reservation => reservation.Offer).Where(
                        reservation => reservation.Offer.AgencyId == agencyId &&
                                       DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start &&
                                       DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
                    .GroupBy(reservation => reservation.ArrivalDate.Year)
                    .OrderBy(group => group.Key)
                    .Select(group => new SalesResponse
                    {
                        Group = group.Key.ToString(), Total = group.Count(),
                        MoneyAmount = group.Sum(reservation => reservation.Price)
                    });
                break;
            case GroupBy.Month:
                response = _repositories.HotelReservations.FindWithInclude(reservation => reservation.Offer).Where(
                        reservation => reservation.Offer.AgencyId == agencyId &&
                                       DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start &&
                                       DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
                    .GroupBy(reservation => reservation.ArrivalDate.Year)
                    .OrderBy(group => group.Key)
                    .Select(group =>
                        group.GroupBy(reservation => reservation.ArrivalDate.Month).OrderBy(group => group.Key))
                    .Select(year => year.Select(group => new SalesResponse
                    {
                        Group = Month.getMonth(group.Key), Total = group.Count(),
                        MoneyAmount = group.Sum(reservation => reservation.Price)
                    }))
                    .SelectMany(response => response);
                break;
            default:
                return BadRequest("The Group is not supported");
        }

        if (export.HasValue)
        {
            return Ok(_exporterService.getDoc(
                "Hotel Reservation Sales (" + request.Start.ToString() + " - " + request.End.ToString() + ")",
                new string[3] { request.GroupBy.ToString()!, "Total Sales", "Amount (USD)" },
                new float[3] { 30, 15, 15 },
                response.SelectMany(sales => new object[] { sales.Group, sales.Total, sales.MoneyAmount }),
                export.Value
            ));
        }

        return Ok(response);
    }
}