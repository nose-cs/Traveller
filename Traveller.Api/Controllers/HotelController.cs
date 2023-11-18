using Microsoft.AspNetCore.Mvc;
using Traveller.Dtos;
using Traveller.Persistence.Repositories;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelController : ControllerBase
{
    private readonly Repositories _repositories;
 
    private readonly ILogger<HotelController> _logger;

    public HotelController(ILogger<HotelController> logger, Repositories repositories)
    {
        _logger = logger;
        _repositories = repositories;
    } 

    [HttpPost]
    public async Task<ActionResult> Create(HotelDto hotelDto)
    {
        try
        {
            await _repositories.Hotels.AddAsync(HotelDto.Map(hotelDto));
            
            await _repositories.Hotels.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
    
    [HttpPut("{id:int}")]
    public async Task<ActionResult> Update([FromBody] HotelDto hotelDto, [FromRoute] int id)
    {
        try
        {
            var dbHotel = await _repositories.Hotels.FindById(id);
            if (dbHotel is null)
            {
                return NotFound($"Hotel with id {id} doesn't exist");
            }

            dbHotel.Address = hotelDto.Address;
            dbHotel.Name = hotelDto.Name;
            dbHotel.Category = dbHotel.Category;
            
            await _repositories.Hotels.SaveChangesAsync();
            
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
            await _repositories.Hotels.Remove(id);
            await _repositories.Hotels.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<HotelDto>> GetAll() => Ok(_repositories.Hotels.Find().Select(HotelDto.Map));

    [HttpGet("Get")]
    public ActionResult<IEnumerable<HotelDto>> Get([FromQuery] HotelFilterDTO filter) =>
        Ok(_repositories.Hotels.Find().
                Where((ho => (filter.Category is null || filter.Category == ho.Category) &&
                      (filter.Name is null || ho.Name.Contains(filter.Name)) &&
                      (filter.Address is null || ho.Address.Contains(filter.Address)) &&
                      (filter.ProductId is null || ho.Id == filter.ProductId))).
                Select(HotelDto.Map));
        

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbHotel = await _repositories.Hotels.FindById(id);
            if (dbHotel is null)
            {
                return NotFound($"Hotel with id {id} doesn't exist");
            }

            return Ok(HotelDto.Map(dbHotel));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}