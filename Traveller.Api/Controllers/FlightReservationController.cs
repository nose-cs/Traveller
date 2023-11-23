using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Persistence.Repositories;
namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FlightReservationController : ControllerBase
{
    private readonly Repositories _repositories;
 
    private readonly ILogger<FlightReservationController> _logger;

    public FlightReservationController(ILogger<FlightReservationController> logger, Repositories repositories)
    {
        _logger = logger;
        _repositories = repositories;
    }

    [HttpPost]
    [Authorize(Roles = ("Agent, Tourist"))]
    public async Task<ActionResult> Create(ReservationDto reservationDto)
    {
        if (await _repositories.FlightOffers.FindById(reservationDto.OfferId) == null)
            return NotFound($"Flight Offer id: {reservationDto.OfferId} doesn´t exists");

        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var role = jwt.Claims.First(c => c.Type == "role").Value;
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);
        if ((role == "Tourist") && (userId != reservationDto.TouristId))
            return BadRequest($"Tourists can only make reservations for themselves");

        FlightReservation reservation = new FlightReservation();
        ReservationDto.Map<Flight, FlightReservation, FlightOffer>(reservation, reservationDto);
        if (reservationDto.paymentDto.Total < reservationDto.Price)
            return BadRequest("The payment is not enough");
        try
        {
            await _repositories.FlightReservations.AddAsync(reservation);
            await _repositories.Payment.AddAsync(PaymentDto.Map(reservationDto.paymentDto));
            await _repositories.Payment.SaveChangesAsync();
            await _repositories.FlightReservations.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
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
            var dbFlightReservation = await _repositories.FlightReservations.FindById(id);
            if (dbFlightReservation is null)
                return NotFound($"Flight Reservation with id {id} doesn't exist");
            int old_PaymentId = dbFlightReservation.PaymentId;//no quiero que nadie pueda modificar el PaymentId
            double old_Price = dbFlightReservation.Price;        //ni los turistas el precio

            ReservationDto.Map<Flight, FlightReservation, FlightOffer>(dbFlightReservation, reservationDto);
            dbFlightReservation.PaymentId = old_PaymentId;
            if (role == "Tourist")
                dbFlightReservation.Price = old_Price;

            await _repositories.FlightReservations.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
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
            await _repositories.Payment.Remove(dbFlightReservation.PaymentId);
            await _repositories.FlightReservations.Remove(id);
            await _repositories.Payment.SaveChangesAsync();
            await _repositories.FlightReservations.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
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

        var dtos = _repositories.FlightReservations.Find().Select(ReservationDto.Map<Flight, FlightReservation, FlightOffer>);

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
            var flightReservation = await _repositories.FlightReservations.FindById(id);
            if (flightReservation is null)
                return NotFound($"Flight reservation with id {id} doesn't exist");
            if ((role == "Tourist") && (userId != flightReservation.TouristId))
                return BadRequest($"Tourists can only see their own reservations");
            return Ok(ReservationDto.Map<Flight, FlightReservation, FlightOffer>(flightReservation));  
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}