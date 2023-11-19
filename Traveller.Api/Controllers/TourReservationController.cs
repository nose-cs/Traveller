using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Persistence.Repositories;
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
    public async Task<ActionResult> Create(ReservationDto reservationDto)
    {
        try
        {
            TourReservation reservation = new TourReservation();
            ReservationDto.Map<Tour, TourReservation, TourOffer>(reservation, reservationDto);
            await _repositories.TourReservations.AddAsync(reservation);
            
            await _repositories.TourReservations.SaveChangesAsync();
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
            var dbTourReservation = await _repositories.TourReservations.FindById(id);
            if (dbTourReservation is null)
            {
                return NotFound($"Tour Reservation with id {id} doesn't exist");
            }
            
            ReservationDto.Map<Tour, TourReservation, TourOffer>(dbTourReservation, reservationDto);
            
            await _repositories.TourReservations.SaveChangesAsync();
            
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
            await _repositories.TourReservations.Remove(id);
            await _repositories.TourReservations.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<ReservationDto>> GetAll() => Ok(_repositories.TourReservations.Find().Select(ReservationDto.Map<Tour, TourReservation, TourOffer>));
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var tourReservation = await _repositories.TourReservations.FindById(id);
            if (tourReservation is null)
            {
                return NotFound($"Tour reservation with id {id} doesn't exist");
            }
            return Ok(ReservationDto.Map<Tour, TourReservation, TourOffer>(tourReservation));  
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}