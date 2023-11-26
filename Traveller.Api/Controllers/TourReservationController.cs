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
public class TourReservationController : ControllerBase
{
    private readonly Repositories _repositories;

    private readonly ILogger<TourReservationController> _logger;

    public TourReservationController(ILogger<TourReservationController> logger, Repositories repositories)
    {
        _logger = logger;
        _repositories = repositories;
    }

    [HttpPost]
    [Authorize(Roles = ("Agent, Tourist"))]
    public async Task<ActionResult> Create(ReservationDto reservationDto)
    {
        if (await _repositories.TourOffers.FindById(reservationDto.OfferId) == null)
            return NotFound($"Tour Offer id: {reservationDto.OfferId} doesn´t exists");

        var token = Request.Headers.Authorization[0]![7..];
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);
        if (role == "Tourist" && userId != reservationDto.TouristId)
            return Unauthorized($"Tourists can only make reservations for themselves");

        try
        {
            var reservation = new TourReservation();
            ReservationDto.Map<Tour, TourReservation, TourOffer>(reservation, reservationDto);
            if (reservationDto.paymentDto.Total < reservationDto.Price)
                return BadRequest("The payment is not enough");
            await _repositories.Payment.AddAsync(PaymentDto.Map(reservationDto.paymentDto));
            await _repositories.Payment.SaveChangesAsync();
            await _repositories.TourReservations.AddAsync(reservation);
            await _repositories.TourReservations.SaveChangesAsync();
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
        if (role == "Tourist" && userId != reservationDto.TouristId)
            return BadRequest($"Tourists can only change their own reservations");

        try
        {
            var dbTourReservation = await _repositories.TourReservations.FindById(id);
            if (dbTourReservation is null)
                return NotFound($"Tour Reservation with id {id} doesn't exist");
            var oldPaymentId = dbTourReservation.PaymentId; //no quiero que nadie pueda modificar el PaymentId
            var oldPrice = dbTourReservation.Price; //ni los turistas el precio

            ReservationDto.Map<Tour, TourReservation, TourOffer>(dbTourReservation, reservationDto);
            dbTourReservation.PaymentId = oldPaymentId;
            if (role == "Tourist")
                dbTourReservation.Price = oldPrice;

            await _repositories.Payment.SaveChangesAsync();
            await _repositories.TourReservations.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpDelete("{id:int}")]
    [Authorize(Roles = "Agent, Tourist")]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);

        try
        {
            var dbTourReservation = await _repositories.TourReservations.FindById(id);
            if (dbTourReservation is null)
                return NotFound($"Tour reservation with id {id} doesn't exist");
            if ((role == "Tourist") && (userId != dbTourReservation.TouristId))
                return BadRequest($"Tourists can only delete their own reservations");
            await _repositories.Payment.Remove(dbTourReservation.PaymentId);
            await _repositories.TourReservations.Remove(id);
            await _repositories.TourReservations.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    [Authorize(Roles = "Agent, Tourist")]
    public ActionResult<IEnumerable<ReservationDto>> GetAll()
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);

        var dtos = _repositories.TourReservations.Find().Select(ReservationDto.Map<Tour, TourReservation, TourOffer>);

        if (role == "Tourist")
            dtos = dtos.Where(rsv => (rsv.TouristId == userId));
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
            var tourReservation = await _repositories.TourReservations.FindById(id);
            if (tourReservation is null)
                return NotFound($"Tour reservation with id {id} doesn't exist");
            if ((role == "Tourist") && (userId != tourReservation.TouristId))
                return BadRequest($"Tourists can only see their own reservations");
            return Ok(ReservationDto.Map<Tour, TourReservation, TourOffer>(tourReservation));
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
                return Ok(_repositories.TourReservations.FindWithInclude(reservation => reservation.Offer).Where(reservation => reservation.Offer.AgencyId == agencyId && DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start && DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
                                              .GroupBy(reservation => DateOnly.FromDateTime(reservation.ArrivalDate))
                                              .OrderBy(group => group.Key)
                                              .Select(group => new SalesResponse { Group = group.Key.ToString(), Total = group.Count(), MoneyAmount = group.Sum(reservation => reservation.Price) }));
            case GroupBy.Year:
                return Ok(_repositories.TourReservations.FindWithInclude(reservation => reservation.Offer).Where(reservation => reservation.Offer.AgencyId == agencyId && DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start && DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
                                              .GroupBy(reservation => reservation.ArrivalDate.Year)
                                              .OrderBy(group => group.Key)
                                              .Select(group => new SalesResponse { Group = group.Key.ToString(), Total = group.Count(), MoneyAmount = group.Sum(reservation => reservation.Price) }));
            case GroupBy.Month:
                return Ok(_repositories.TourReservations.FindWithInclude(reservation => reservation.Offer).Where(reservation => reservation.Offer.AgencyId == agencyId && DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start && DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
                                              .GroupBy(reservation => reservation.ArrivalDate.Year)
                                              .OrderBy(group => group.Key)
                                              .Select(group => group.GroupBy(reservation => reservation.ArrivalDate.Month).OrderBy(group => group.Key))
                                              .Select(year => year.Select(group => new SalesResponse { Group = Month.getMonth(group.Key), Total = group.Count(), MoneyAmount = group.Sum(reservation => reservation.Price) }))
                                              .SelectMany(response => response));
        }

        return BadRequest("The Group is not supported");
    }
}