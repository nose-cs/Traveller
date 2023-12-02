using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using Traveller.Domain;
using Traveller.Domain.Models;
using Traveller.Dtos;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelReservationController : ControllerBase
{
    private readonly Repositories _repositories;

    private readonly ILogger<HotelReservationController> _logger;

    public HotelReservationController(ILogger<HotelReservationController> logger, Repositories repositories)
    {
        _logger = logger;
        _repositories = repositories;
    }

    [HttpPost]
    [Authorize(Roles = ("Agent, Tourist"))]
    public async Task<ActionResult> Create(ReservationDto reservationDto)
    {
        if (await _repositories.HotelOffers.FindById(reservationDto.OfferId) == null)
            return NotFound($"Hotel Offer id: {reservationDto.OfferId} doesn´t exists");

        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);
        if ((role == "Tourist") && (userId != reservationDto.TouristId))
            return BadRequest($"Tourists can only make reservations for themselves");

        try
        {
            HotelReservation reservation = new HotelReservation();
            Payment payment = reservationDto.Get_Payment();
            ReservationDto.Map<Hotel, HotelReservation, HotelOffer>(reservation, reservationDto);
            await _repositories.Payment.AddAsync(payment);
            await _repositories.Payment.SaveChangesAsync();
            reservation.PaymentId = payment.Id;
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
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);
        if ((role == "Tourist") && (userId != reservationDto.TouristId))
            return BadRequest($"Tourists can only change their own reservations");

        try
        {
            var dbHotelReservation = await _repositories.HotelReservations.FindById(id);
            if (dbHotelReservation is null)
                return NotFound($"Hotel Reservation with id {id} doesn't exist");
            var oldPaymentId = dbHotelReservation.PaymentId; //no quiero que nadie pueda modificar el PaymentId
            var oldPrice = dbHotelReservation.Price; //ni los turistas el precio

            ReservationDto.Map<Hotel, HotelReservation, HotelOffer>(dbHotelReservation, reservationDto);
            dbHotelReservation.PaymentId = oldPaymentId;
            if (role == "Tourist")
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
    public ActionResult<IEnumerable<ReservationDto>> GetAll()
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);

        IEnumerable<ReservationDto> dtos; 

        if (role == "Tourist")
            dtos = _repositories.HotelReservations.Find()
            .Where(rsv => (rsv.TouristId == userId)).Select(ReservationDto.Map<Hotel, HotelReservation, HotelOffer>);
        else
        {
            var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);
            
            dtos = _repositories.HotelReservations.FindWithInclude(x => x.Offer)
            .Where(rsv => (rsv.Offer.AgencyId == agencyId)).Select(ReservationDto.Map<Hotel, HotelReservation, HotelOffer>);
        }
        return Ok(dtos);
    }

    [HttpGet("{id:int}")]
    [Authorize(Roles = ("Agent, Tourist"))]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);

        try
        {
            var hotelReservation = await _repositories.HotelReservations.FindById(id);
            if (hotelReservation is null)
                return NotFound($"Hotel reservation with id {id} doesn't exist");
            if ((role == "Tourist") && (userId != hotelReservation.TouristId))
                return BadRequest($"Tourists can only see their own reservations");
            return Ok(ReservationDto.Map<Hotel, HotelReservation, HotelOffer>(hotelReservation));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet("getSales")]
    [Authorize(Roles = ("MarketingEmployee, Admin"))]
    public ActionResult GetSales([FromQuery] SalesRequest request)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        if (request.GroupBy == null)
            request.GroupBy = GroupBy.Day;

        switch (request.GroupBy)
        {
            case GroupBy.Day:
                return Ok(_repositories.HotelReservations.FindWithInclude(reservation => reservation.Offer).Where(reservation => reservation.Offer.AgencyId == agencyId && DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start && DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
                                              .GroupBy(reservation => DateOnly.FromDateTime(reservation.ArrivalDate))
                                              .OrderBy(group => group.Key)
                                              .Select(group => new SalesResponse { Group = group.Key.ToString(), Total = group.Count(), MoneyAmount = group.Sum(reservation => reservation.Price) }));
            case GroupBy.Year:
                return Ok(_repositories.HotelReservations.FindWithInclude(reservation => reservation.Offer).Where(reservation => reservation.Offer.AgencyId == agencyId && DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start && DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
                                              .GroupBy(reservation => reservation.ArrivalDate.Year)
                                              .OrderBy(group => group.Key)
                                              .Select(group => new SalesResponse { Group = group.Key.ToString(), Total = group.Count(), MoneyAmount = group.Sum(reservation => reservation.Price) }));
            case GroupBy.Month:
                return Ok(_repositories.HotelReservations.FindWithInclude(reservation => reservation.Offer).Where(reservation => reservation.Offer.AgencyId == agencyId && DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start && DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
                                              .GroupBy(reservation => reservation.ArrivalDate.Year)
                                              .OrderBy(group => group.Key)
                                              .Select(group => group.GroupBy(reservation => reservation.ArrivalDate.Month).OrderBy(group => group.Key))
                                              .Select(year => year.Select(group => new SalesResponse { Group = Month.getMonth(group.Key), Total = group.Count(), MoneyAmount = group.Sum(reservation => reservation.Price) }))
                                              .SelectMany(response => response));
        }

        return BadRequest("The Group is not supported");
    }
}