using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Persistence.Repositories;
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
    public async Task<ActionResult> Create(ReservationDto reservationDto)
    {
        try
        {
            HotelReservation reservation = new HotelReservation();
            ReservationDto.Map<Hotel, HotelReservation, HotelOffer>(reservation, reservationDto);
            await _repositories.HotelReservations.AddAsync(reservation);
            
            await _repositories.HotelReservations.SaveChangesAsync();
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
            var dbHotelReservation = await _repositories.HotelReservations.FindById(id);
            if (dbHotelReservation is null)
            {
                return NotFound($"Hotel Reservation with id {id} doesn't exist");
            }
            ReservationDto.Map<Hotel, HotelReservation, HotelOffer>(dbHotelReservation, reservationDto);

            await _repositories.HotelReservations.SaveChangesAsync();
            
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
            await _repositories.HotelReservations.Remove(id);
            await _repositories.HotelReservations.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<ReservationDto>> GetAll() => Ok(_repositories.HotelReservations.Find().Select(ReservationDto.Map<Hotel, HotelReservation, HotelOffer>));
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var hotelReservation = await _repositories.HotelReservations.FindById(id);
            if (hotelReservation is null)
            {
                return NotFound($"Hotel reservation with id {id} doesn't exist");
            }
            return Ok(ReservationDto.Map<Hotel, HotelReservation, HotelOffer>(hotelReservation));  
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}