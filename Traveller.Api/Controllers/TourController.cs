using Microsoft.AspNetCore.Mvc;
using Traveller.Domain;
using Traveller.Domain.Interfaces.Models;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;
using Traveller.Dtos;

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
            return StatusCode(StatusCodes.Status500InternalServerError);
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

            dbTour.SourcePlaceId = tourDto.SourceInfo.Place.Id;
            dbTour.SourceDay = tourDto.SourceInfo.Day;
            dbTour.SourceTime = tourDto.SourceInfo.Time;
            dbTour.DestinationPlaceId = tourDto.DestinationInfo.Place.Id;
            dbTour.DestinationTime = tourDto.DestinationInfo.Time;
            dbTour.Duration = tourDto.Duration;

            await _repositories.Tours.SaveChangesAsync();

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
            await _repositories.Tours.Remove(id);
            await _repositories.Tours.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }


    [HttpGet]
    public ActionResult<IEnumerable<TourDto>> GetToursWithFilter([FromQuery] TourFilterDTO filter)
    {
        var items = _repositories.Tours.Find().Where(fl =>
                   (filter.Id is null || filter.Id == fl.Id)
                && (filter.Duration is null || filter.Duration == fl.Duration)
                && (filter.StartDay is null || fl.SourceDay == filter.StartDay)
                && (filter.Source is null || fl.SourcePlace.Address.ToLower().Contains(filter.Source.ToLower())
                                          || fl.SourcePlace.City.ToLower().Contains(filter.Source.ToLower())
                                          || fl.SourcePlace.Country.ToLower().Contains(filter.Source.ToLower()))
                && (filter.Destination is null || fl.DestinationPlace.Address.ToLower().Contains(filter.Destination.ToLower())
                                               || fl.DestinationPlace.Country.ToLower().Contains(filter.Destination.ToLower())
                                               || fl.DestinationPlace.City.ToLower().Contains(filter.Destination.ToLower())));

        if (filter.OrderBy != null) {
            switch (filter.OrderBy)
            {
                case ("Duration"):
                    items = items.OrderBy(item => item.Duration); break;
                case ("SourceDay"):
                    items = items.OrderBy(item => item.SourceDay); break;
                default:
                    items = items.OrderBy(item => item.Id); break;
            }
        }

        if (filter.Descending.HasValue && filter.Descending.Value)
            items = items.Reverse();
        var pageItems = (filter.PageIndex == null || filter.PageSize == null ? items : items.Take(new Range((filter.PageIndex.Value - 1) * filter.PageSize.Value, (filter.PageIndex.Value - 1) * filter.PageSize.Value + filter.PageSize.Value)))
        .Select(TourDto.Map);

        return Ok(new PaginationResponse<TourDto>() { TotalCollectionSize = items.Count(), Items = pageItems });
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbTour = await _repositories.Tours.FindById(id);
            if (dbTour is null)
            {
                return NotFound($"Tour with id {id} doesn't exist");
            }

            return Ok(TourDto.Map(dbTour));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
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
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    

    [HttpGet("{id:int}/offers")]
    public IActionResult GetTourOffers([FromRoute] int id, [FromQuery] OfferFilterDTO filter)
    {
        var offers = _repositories.TourOffers.Find().Where(
                to => to.ProductId == id
                      && (filter.StartPrice == null || to.Price >= filter.StartPrice)
                      && (filter.EndPrice == null || to.Price <= filter.EndPrice)
                      && (filter.StartDate == null || to.StartDate <= filter.StartDate && (to.EndDate == null || to.EndDate >= filter.StartDate))
                      && (filter.AgencyId == null || to.AgencyId == filter.AgencyId))
            .ToArray().Select(offer =>
            {
                var dto = OfferDto.Map<Tour, TourReservation, TourOffer>(offer);
                dto.AgencyName = _repositories.Agencies.GetName(offer.AgencyId);
                dto.ProductName = _repositories.Flights.GetName(offer.ProductId);
                return dto;
            });
        return Ok(offers);
    }

    [HttpGet("getMostSolds")]
    public IActionResult GetMostSolds()
    {
        return Ok(_repositories.TourReservations.FindWithInclude(reservation => reservation.Offer)
                                       .Where(reservation => reservation.ArrivalDate >= DateTime.UtcNow.AddMonths(-1))
                                       .GroupBy(reservation => reservation.Offer.ProductId)
                                       .OrderBy(group => -group.Count())
                                       .Take(20)
                                       .Join(_repositories.Tours.Find(), group => group.Key, model => model.Id, (group, model) => TourDto.Map(model)));
    }
}