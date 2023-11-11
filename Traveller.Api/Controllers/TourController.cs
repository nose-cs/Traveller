using Microsoft.AspNetCore.Mvc;
using Traveller.Dtos;
using Traveller.Persistence.Repositories;

namespace Traveller.Controllers;

[ApiController]
[Route("[controller]")]
public class TourController : ControllerBase
{
    private readonly TourRepository _repository;
 
    private readonly ILogger<HotelController> _logger;

    public TourController(ILogger<HotelController> logger, TourRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpPost]
    public async Task<ActionResult> Create(TourDto tourDto)
    {
        try
        {
            await _repository.AddAsync(TourDto.Map(tourDto));
            
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
    public async Task<ActionResult> Update([FromBody] TourDto tourDto, [FromRoute] int id)
    {
        try
        {
            var dbTour = await _repository.FindById(id);
            if (dbTour is null)
            {
                return NotFound($"Hotel with id {id} doesn't exist");
            }

            dbTour.ArrivalDay = tourDto.ArrivalInfo.Day;
            dbTour.ArrivalPlace = tourDto.ArrivalInfo.Place;
            dbTour.ArrivalTime = tourDto.ArrivalInfo.Time;
            
            dbTour.DepartureDay = tourDto.DepartureInfo.Day;
            dbTour.DeparturePlace = tourDto.DepartureInfo.Place;
            dbTour.DepartureTime = tourDto.DepartureInfo.Time;
            
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
    public ActionResult<IEnumerable<HotelDto>> GetAll() => Ok(_repository.Find().Select(TourDto.Map));
    

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbTour = await _repository.FindById(id);
            if (dbTour is null)
            {
                return NotFound($"Hotel with id {id} doesn't exist");
            }

            return Ok(TourDto.Map(dbTour));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}