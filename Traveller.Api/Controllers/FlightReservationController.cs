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
    public async Task<ActionResult> Create(ReservationDto reservationDto)
    {
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
    public async Task<ActionResult> Update([FromBody] ReservationDto reservationDto, [FromRoute] int id)
    {
        try
        {
            var dbFlightReservation = await _repositories.FlightReservations.FindById(id);
            int old_PaymentId = dbFlightReservation.PaymentId;//no quiero que nadie pueda modificar el PaymentId
            if (dbFlightReservation is null)
            {
                return NotFound($"Flight Reservation with id {id} doesn't exist");
            }

            ReservationDto.Map<Flight, FlightReservation, FlightOffer>(dbFlightReservation, reservationDto);
            dbFlightReservation.PaymentId = old_PaymentId;

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
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
        try
        {
            var dbFlightReservation = await _repositories.FlightReservations.FindById(id);
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
    public ActionResult<IEnumerable<ReservationDto>> GetAll() => Ok(_repositories.FlightReservations.Find().Select(ReservationDto.Map<Flight, FlightReservation, FlightOffer>));
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var flightReservation = await _repositories.FlightReservations.FindById(id);
            if (flightReservation is null)
            {
                return NotFound($"Flight reservation with id {id} doesn't exist");
            }
            return Ok(ReservationDto.Map<Flight, FlightReservation, FlightOffer>(flightReservation));  
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}