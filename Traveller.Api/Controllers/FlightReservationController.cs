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
public class FlightReservationController : ControllerBase
{
    private readonly Repositories _repositories;
    private readonly ExporterService _exporterService;

    private readonly ILogger<FlightReservationController> _logger;

    public FlightReservationController(ILogger<FlightReservationController> logger, Repositories repositories, ExporterService exporterService)
    {
        _logger = logger;
        _repositories = repositories;
        _exporterService = exporterService;
    }

    [HttpPost]
    [Authorize(Roles = ("Agent, Tourist"))]
    public async Task<ActionResult> Create(ReservationDto reservationDto)
    {
        var user = await _repositories.Users.FindById(reservationDto.TouristId);
        
        if (user is null)
            return NotFound($"User with id {reservationDto.TouristId} doesn't exist");
        
        if (user.Role != Role.Tourist)
            return BadRequest("Only tourists can make reservations");

        if (reservationDto.NumberOfTravellers <= 0)
            return BadRequest("The number of travellers must be greater than 0");
            
        var offer = await _repositories.FlightOffers.FindById(reservationDto.OfferId);
        
        if (offer is null)
            return NotFound($"Flight Offer id: {reservationDto.OfferId} doesn´t exists");
        
        var token = Request.Headers.Authorization[0]![7..];
        var jwt = new JwtSecurityToken(token);
        
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);
        
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        
        if (role == "Tourist")
        {
            reservationDto.TouristId = userId;
        }
            
        if (int.TryParse(jwt.Claims.First(c => c.Type == "agencyId").Value, out var agencyId)
            && agencyId != offer.AgencyId)
        {
            return Unauthorized("You don't have permission for this action");
        }

        if (offer.Capacity < reservationDto.NumberOfTravellers)
            return BadRequest(
                $"The offer doesn't have enough capacity for {reservationDto.NumberOfTravellers} travellers");
        
        
        if (reservationDto.ArrivalDate < offer.StartDate || reservationDto.DepartureDate > offer.EndDate)
            return BadRequest("Offer is not available in this range of dates");
            
        if (reservationDto.ArrivalDate > reservationDto.DepartureDate || reservationDto.ArrivalDate < DateTime.Now)
            return BadRequest("The date range is not valid");

        offer.Capacity = (uint)(offer.Capacity - reservationDto.NumberOfTravellers);
        try
        {
            var reservation = new FlightReservation();
            var price = offer.Price * reservationDto.NumberOfTravellers;
            reservation.Price = price;
            var payment = reservationDto.GetPayment(price);
            ReservationDto.Map<Flight, FlightReservation, FlightOffer>(reservation, reservationDto);
            await _repositories.Payment.AddAsync(payment);
            reservation.Payment = payment;
            await _repositories.FlightReservations.AddAsync(reservation);
            await _repositories.FlightReservations.SaveChangesAsync();
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
            var dbFlightReservation = await _repositories.FlightReservations.FindById(id);
            
            if (dbFlightReservation is null)
                return NotFound($"Flight Reservation with id {id} doesn't exist");

            var token = Request.Headers.Authorization[0]!.Substring(7);
            var jwt = new JwtSecurityToken(token);
            var role = jwt.Claims.First(c => c.Type == "role").Value;
            var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);
            

            if (role == "Tourist" && userId != dbFlightReservation.TouristId)
                return BadRequest($"Tourists can only change their own reservations");

            var offer = await _repositories.FlightOffers.FindById(dbFlightReservation.OfferId);

            if(role == "Agent")
            {
                var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

                if (agencyId != offer!.AgencyId)
                    return BadRequest("Agents can only change reservations for they own agency");
            }

            var oldPaymentId = dbFlightReservation.PaymentId; //no quiero que nadie pueda modificar el PaymentId
            var oldPrice = dbFlightReservation.Price; //ni el precio

            ReservationDto.Map<Flight, FlightReservation, FlightOffer>(dbFlightReservation, reservationDto);
            dbFlightReservation.PaymentId = oldPaymentId;
            dbFlightReservation.Price = oldPrice;

            await _repositories.FlightReservations.SaveChangesAsync();

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
            var dbFlightReservation = await _repositories.FlightReservations.FindById(id);
            
            if (dbFlightReservation is null)
                return NotFound($"Flight reservation with id {id} doesn't exist");
            
            if ((role == "Tourist") && (userId != dbFlightReservation.TouristId))
                return BadRequest($"Tourists can only delete their own reservations");

            var offer = await _repositories.FlightOffers.FindById(dbFlightReservation.OfferId);

            if (role == "Agent")
            {
                var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

                if (agencyId != offer!.AgencyId)
                    return BadRequest("Agents can only change reservations for they own agency");
            }

            await _repositories.Payment.Remove(dbFlightReservation.PaymentId);
            await _repositories.FlightReservations.Remove(id);
            await _repositories.FlightReservations.SaveChangesAsync();

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

        var items = _repositories.FlightReservations.FindWithInclude(f => f.Offer);

        if (role == "Tourist")
            items = items.Where(rsv => rsv.TouristId == userId);
        else {
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
                            .Select(ReservationDto.Map<Flight, FlightReservation, FlightOffer>);

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
            var flightReservation = await _repositories.FlightReservations.FindById(id);
            
            if (flightReservation is null)
                return NotFound($"Flight reservation with id {id} doesn't exist");
            
            if ((role == "Tourist") && (userId != flightReservation.TouristId))
                return BadRequest($"Tourists can only see their own reservations");
            
            if(role == "Agent")
            {
                var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

                var offer = await _repositories.FlightOffers.FindById(flightReservation.OfferId);

                if(agencyId != offer!.AgencyId)
                    return BadRequest("Agents can only see their own agency reservations");
            }

            return Ok(ReservationDto.Map<Flight, FlightReservation, FlightOffer>(flightReservation));
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
                response = _repositories.FlightReservations.FindWithInclude(reservation => reservation.Offer).Where(reservation => reservation.Offer.AgencyId == agencyId && DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start && DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
                                              .GroupBy(reservation => DateOnly.FromDateTime(reservation.ArrivalDate))
                                              .OrderBy(group => group.Key)
                                              .Select(group => new SalesResponse { Group = group.Key.ToString(), Total = group.Count(), MoneyAmount = group.Sum(reservation => reservation.Price) });
                break;
            case GroupBy.Year:
                response = _repositories.FlightReservations.FindWithInclude(reservation => reservation.Offer).Where(reservation => reservation.Offer.AgencyId == agencyId && DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start && DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
                                              .GroupBy(reservation => reservation.ArrivalDate.Year)
                                              .OrderBy(group => group.Key)
                                              .Select(group => new SalesResponse { Group = group.Key.ToString(), Total = group.Count(), MoneyAmount = group.Sum(reservation => reservation.Price) });
                break;
            case GroupBy.Month:
                response = _repositories.FlightReservations.FindWithInclude(reservation => reservation.Offer).Where(reservation => reservation.Offer.AgencyId == agencyId && DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start && DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
                                              .GroupBy(reservation => reservation.ArrivalDate.Year)
                                              .OrderBy(group => group.Key)
                                              .Select(group => group.GroupBy(reservation => reservation.ArrivalDate.Month).OrderBy(group => group.Key))
                                              .Select(year => year.Select(group => new SalesResponse { Group = Month.getMonth(group.Key), Total = group.Count(), MoneyAmount = group.Sum(reservation => reservation.Price) }))
                                              .SelectMany(response => response);
                break;
            default:
                return BadRequest("The Group is not supported");
        }

        if (export.HasValue)
        {
            return Ok(_exporterService.getDoc("Flight Reservation Sales (" + request.Start.ToString() + " - " + request.End.ToString() + ")",
                                                new string[3] { request.GroupBy.ToString()!, "Total Sales", "Amount (USD)" },
                                                new float[3] { 30, 15, 15 },
                                                response.SelectMany(sales => new string[] { sales.Group, sales.Total.ToString(), sales.MoneyAmount.ToString() }),
                                                export.Value
                                                ));
        }

        return Ok(response);
    }
}