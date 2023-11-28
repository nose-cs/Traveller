using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics;
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
            return StatusCode(StatusCodes.Status500InternalServerError);
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
            return StatusCode(StatusCodes.Status500InternalServerError);
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
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<HotelDto>> Get([FromQuery] HotelFilterDTO filter) =>
        Ok(_repositories.Hotels.Find().Where((ho => (filter.Category is null || filter.Category == ho.Category) &&
                                                    (filter.Name is null || ho.Name.Contains(filter.Name)) &&
                                                    (filter.Address is null) &&
                                                    (filter.ProductId is null || ho.Id == filter.ProductId)))
            .Select(HotelDto.Map));


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
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpGet("{id:int}/offers")]
    public IActionResult GetHotelOffers([FromRoute] int id, [FromQuery] OfferFilterDTO filter)
    {
        var offers = _repositories.HotelOffers.Find().Where(
                to => to.ProductId == id
                      && (filter.StartPrice == null || to.Price >= filter.StartPrice)
                      && (filter.EndPrice == null || to.Price <= filter.EndPrice)
                      && (filter.StartDate == null || to.StartDate <= filter.StartDate && (to.EndDate == null || to.EndDate >= filter.StartDate))
                      && (filter.AgencyId == null || to.AgencyId == filter.AgencyId))
            .ToArray().Select(offer =>
            {
                var dto = OfferDto.Map<Hotel, HotelReservation, HotelOffer>(offer);
                dto.AgencyName = _repositories.Agencies.GetName(offer.AgencyId);
                dto.ProductName = _repositories.Flights.GetName(offer.ProductId);
                return dto;
            });
        return Ok(offers);
    }

    [HttpGet("getMostSolds")]
    public IActionResult GetMostSolds()
    {
        return Ok(_repositories.HotelReservations.FindWithInclude(reservation => reservation.Offer)
                                       .Where(reservation => reservation.ArrivalDate >= DateTime.UtcNow.AddMonths(-1))
                                       .GroupBy(reservation => reservation.Offer.ProductId)
                                       .OrderBy(group => -group.Count())
                                       .Take(20)
                                       .Join(_repositories.Hotels.Find(), group => group.Key, hotel => hotel.Id, (group, hotel) => hotel));
    }
}