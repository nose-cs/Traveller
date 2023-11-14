using Microsoft.AspNetCore.Mvc;
using Traveller.Dtos;
using Traveller.Persistence.Repositories;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TourController : ControllerBase
{
    private readonly Repositories _repositories;
 
    private readonly ILogger<HotelController> _logger;

    public TourController(ILogger<HotelController> logger, Repositories repositories)
    {
        _logger = logger;
        _repositories = repositories;
    }

    [HttpPost]
    public async Task<ActionResult> Create(TourDto tourDto)
    {
        try
        {
            await _repositories.Tours.AddAsync(TourDto.Map(tourDto));
            
            await _repositories.Tours.SaveChangesAsync();
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
            var dbTour = await _repositories.Tours.FindById(id);
            if (dbTour is null)
            {
                return NotFound($"Tour with id {id} doesn't exist");
            }

            dbTour.ArrivalDay = tourDto.ArrivalInfo.Day;
            dbTour.ArrivalPlace = tourDto.ArrivalInfo.Place;
            dbTour.ArrivalTime = tourDto.ArrivalInfo.Time;
            
            dbTour.Duration = tourDto.Duration;
            dbTour.DeparturePlace = tourDto.DepartureInfo.Place;
            dbTour.DepartureTime = tourDto.DepartureInfo.Time;
            
            await _repositories.Tours.SaveChangesAsync();
            
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
            await _repositories.Tours.Remove(id);
            await _repositories.Tours.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<HotelDto>> GetAll() => Ok(_repositories.Tours.Find().Select(TourDto.Map));
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbTour = await _repositories.Tours.FindById(id);
            if (dbTour  is null)
            {
                return NotFound($"Tour with id {id} doesn't exist");
            }

            return Ok(TourDto.Map(dbTour));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{id:int}/packages")]
    public async Task<ActionResult> GetPackages([FromRoute] int id)
    {
        try
        {
            var packages = await _repositories.Tours.FindPackages(id);
            if (packages is null)
            {
                return NotFound($"Tour with id {id} doesn't exist");
            }
            return Ok(packages.Select(PackageDto.Map));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}