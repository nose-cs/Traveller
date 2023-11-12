using Microsoft.AspNetCore.Mvc;
using Traveller.Dtos;
using Traveller.Persistence.Repositories;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FlightController : ControllerBase
{
    private readonly FlightRepository _repository;
 
    private readonly ILogger<HotelController> _logger;

    public FlightController(ILogger<HotelController> logger, FlightRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpPost]
    public async Task<ActionResult> Create(FlightDto flightDto)
    {
        try
        {
            await _repository.AddAsync(FlightDto.Map(flightDto));
            
            await _repository.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
    
    [HttpPut("{id:int}")]
    public async Task<ActionResult> Update([FromBody] FlightDto flightDto, [FromRoute] int id)
    {
        try
        {
            var dbFlight = await _repository.FindById(id);
            if (dbFlight is null)
            {
                return NotFound($"Flight with id {id} doesn't exist");
            }

            dbFlight.FlightNumber = flightDto.FlightNumber;
            dbFlight.Airline = flightDto.Airline;
            dbFlight.Destination = flightDto.Destination;
            dbFlight.Source = flightDto.Source;
            
            await _repository.SaveChangesAsync();
            
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
            await _repository.Remove(id);
            await _repository.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<FlightDto>> GetAll() => Ok(_repository.Find().Select(FlightDto.Map));

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbFlight = await _repository.FindById(id);
            if (dbFlight is null)
            {
                return NotFound($"Flight with id {id} doesn't exist");
            }

            return Ok(FlightDto.Map(dbFlight));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}