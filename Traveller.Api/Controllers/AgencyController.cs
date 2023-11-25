using Microsoft.AspNetCore.Mvc;
using Traveller.Domain;
using Traveller.Dtos;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AgencyController : ControllerBase
{
    private readonly Repositories _repositories;

    private readonly ILogger<HotelController> _logger;

    public AgencyController(Repositories repositories, ILogger<HotelController> logger)
    {
        _repositories = repositories;
        _logger = logger;
    }
    
    [HttpPost]
    public async Task<ActionResult> Create(AgencyDto agencyDto)
    {
        try
        {
            await _repositories.Agencies.AddAsync(AgencyDto.Map(agencyDto));

            await _repositories.Agencies.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Update([FromBody] AgencyDto agencyDto, [FromRoute] int id)
    {
        try
        {
            var dbAgency = await _repositories.Agencies.FindById(id);
            if (dbAgency is null)
            {
                return NotFound($"Agency with id {id} doesn't exist");
            }

            await _repositories.Agencies.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
        try
        {
            await _repositories.Agencies.Remove(id);
            await _repositories.Agencies.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<FlightDto>> GetAll() => Ok(_repositories.Flights.Find().Select(FlightDto.Map));

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbAgency = await _repositories.Agencies.FindById(id);
            if (dbAgency is null)
            {
                return NotFound($"Agency with id {id} doesn't exist");
            }

            return Ok(AgencyDto.Map(dbAgency));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpPost]
    public IActionResult RegisterUser(UserDto user)
    {
        //TODO
        return Ok();
    }
    
    [HttpGet("{id:int}/users")]
    public IActionResult GetUsers()
    {
        //TODO
        return Ok();
    }
    
    [HttpGet("{idAgency:int}/users/{idUser:int}/reservations")]
    public IActionResult GetUserReservations([FromRoute] int idAgency, [FromRoute] int idUser)
    {
        //TODO
        return Ok();
    }
}