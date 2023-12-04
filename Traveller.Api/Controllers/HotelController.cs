using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveller.Domain;
using Traveller.Dtos;
using Traveller.Services;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelController : ControllerBase
{
    private readonly FileService _fileService;
    private readonly Repositories _repositories;

    private readonly ILogger<HotelController> _logger;

    public HotelController(ILogger<HotelController> logger, Repositories repositories, FileService fileService)
    {
        _logger = logger;
        _repositories = repositories;
        _fileService = fileService;
    }

    [HttpPost]
    [Authorize(Roles = ("MarketingEmployee, TravellerAdmin"))]
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
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpPut("{id:int}")]
    [Authorize(Roles = ("TravellerAdmin"))]
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
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpDelete("{id:int}")]
    [Authorize(Roles = ("TravellerAdmin"))]
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
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<HotelDto>>> Get([FromQuery] HotelFilterDTO filter)
    {
        var items = _repositories.Hotels.Find().Where((ho => (filter.Category is null || filter.Category == ho.Category) &&
                                                    (filter.Name is null ||
                                                     ho.Name.ToLower().Contains(filter.Name.ToLower())) &&
                                                    (filter.Address is null || ho.Address.getFullAddress().ToLower()
                                                        .Contains(filter.Address.ToLower())) &&
                                                    (filter.ProductId is null || ho.Id == filter.ProductId)));

        if (filter.OrderBy != null)
        {
            switch (filter.OrderBy)
            {
                case ("Name"):
                    items = items.OrderBy(item => item.Name); break;
                case ("Category"):
                    items = items.OrderBy(item => item.Category); break;
                default:
                    items = items.OrderBy(item => item.Id); break;
            }
        }

        if (filter.Descending.HasValue && filter.Descending.Value)
            items = items.Reverse();

        var pageItems = (filter.PageIndex == null || filter.PageSize == null ? items : items.Take(new Range((filter.PageIndex.Value - 1) * filter.PageSize.Value, (filter.PageIndex.Value - 1) * filter.PageSize.Value + filter.PageSize.Value)))
        .Select(x => HotelDto.Map(x, _fileService.GetRelativePath(x.Image.Name, x.Image.Id), x.Image.Name));

        return Ok(new PaginationResponse<HotelDto>() { TotalCollectionSize = items.Count(), Items = pageItems });
    }

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

            return Ok(HotelDto.Map(dbHotel, _fileService.GetRelativePath(dbHotel.Image.Name, dbHotel.Image.Id), dbHotel.Image.Name));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpGet("{id:int}/fromTour")]
    public async Task<ActionResult> GetHotels([FromRoute] int id)
    {
        try
        {
            var hotels = await _repositories.Tours.FindHotels(id);
            if (hotels is null)
            {
                return NotFound($"Tour with id {id} doesn't exist");
            }

            return Ok(hotels.Select(x =>
                HotelDto.Map(x, _fileService.GetRelativePath(x.Image.Name, x.Image.Id), x.Image.Name)));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpGet("{id:int}/fromPackage")]
    public IActionResult GetHotelsFromPackage([FromRoute] int id)
    {
        return Ok(_repositories
            .Package
            .FindHotels(id)
            .Select(t => HotelDto
                .Map(t, _fileService.GetRelativePath(t.Image.Name, t.Image.Id), t.Image.Name)));

    }

    [HttpGet("getMostSolds")]
    public IActionResult GetMostSolds()
    {
        return Ok(_repositories.HotelReservations.FindWithInclude(reservation => reservation.Offer)
                                       .Where(reservation => reservation.ArrivalDate >= DateTime.UtcNow.AddMonths(-1))
                                       .GroupBy(reservation => reservation.Offer.ProductId)
                                       .OrderBy(group => -group.Count())
                                       .Take(20)
                                       .Join(_repositories.Hotels.Find(), group => group.Key, hotel => hotel.Id, (group, hotel) => HotelDto.Map(hotel, _fileService.GetRelativePath(hotel.Image.Name, hotel.Image.Id), hotel.Image.Name)));
    }
}
