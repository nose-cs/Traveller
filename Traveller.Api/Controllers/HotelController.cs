using Microsoft.AspNetCore.Mvc;
using Traveller.Domain;
using Traveller.Domain.Models;
using Traveller.Dtos;

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

            dbHotel.AddressId = hotelDto.Address.Id;
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
                      (filter.Address is null) &&
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

    [HttpGet("{id:int}/offers")]
    public async Task<ActionResult<IEnumerable<OfferDto>>> GetOffers([FromRoute] int id)
    {
        try
        {
            var hotel = await _repositories.Hotels.FindById(id);
            if (hotel is null)
            {
                return NotFound($"Hotel with id {id} doesn't exist");
            }
            var offers = await _repositories.Hotels.GetOffers(id);
            return Ok(offers.Select(OfferDto.Map<Hotel, HotelReservation, HotelOffer>));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}