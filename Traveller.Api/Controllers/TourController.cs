using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveller.Domain;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Services;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TourController : ControllerBase
{
    private readonly Repositories _repositories;
    private readonly ILogger<HotelController> _logger;
    private readonly FileService _fileService;

    public TourController(ILogger<HotelController> logger, Repositories repositories, FileService fileService)
    {
        _logger = logger;
        _repositories = repositories;
        _fileService = fileService;
    }

    [HttpPost]
    [Authorize(Roles = ("MarketingEmployee, TravellerAdmin"))]
    public async Task<ActionResult> Create(TourDto tourDto)
    {
        try
        {
            var tour = TourDto.Map(tourDto);

            if (tour is ExtendedTour et)
            {
                if (tourDto is { HotelsIds.Length: > 0 })
                {
                    await _repositories.Tours.AddWithHotelsAsync(et, tourDto.HotelsIds.ToHashSet());
                }
                else
                {
                    BadRequest("Extended tours must have at least 1 hotel");
                }
            }
            else
                await _repositories.Tours.AddAsync(tour);

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
    [Authorize(Roles = ("TravellerAdmin"))]
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
    [Authorize(Roles = ("TravellerAdmin"))]
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
            && (filter.Source is null || fl.SourcePlace.getFullAddress().ToLower().Contains(filter.Source.ToLower()))
            && (filter.Destination is null || fl.DestinationPlace.getFullAddress().ToLower().Contains(filter.Destination.ToLower())));

        if (filter.OrderBy != null)
        {
            switch (filter.OrderBy)
            {
                case ("Duration"):
                    items = items.OrderBy(item => item.Duration);
                    break;
                case ("SourceDay"):
                    items = items.OrderBy(item => item.SourceDay);
                    break;
                default:
                    items = items.OrderBy(item => item.Id);
                    break;
            }
        }

        if (filter.Descending.HasValue && filter.Descending.Value)
            items = items.Reverse();
        var pageItems = (filter.PageIndex == null || filter.PageSize == null
                ? items
                : items.Take(new Range((filter.PageIndex.Value - 1) * filter.PageSize.Value,
                    (filter.PageIndex.Value - 1) * filter.PageSize.Value + filter.PageSize.Value)))
            .Select(x => TourDto.Map(x, _fileService.GetRelativePath(x.Image.Name, x.Image.Id), x.Image.Name));

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

            return Ok(TourDto.Map(dbTour, _fileService.GetRelativePath(dbTour.Image.Name, dbTour.Image.Id),
                dbTour.Image.Name));
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
            var tour = await _repositories.Tours.FindById(id);
            if (tour is null)
            {
                return NotFound($"Tour with id {id} doesn't exist");
            }

            var packages = _repositories.Tours.FindPackages(id);
            return Ok(packages.Select(x =>
                PackageDto.Map(x, _fileService.GetRelativePath(x.Image.Name, x.Image.Id), x.Image.Name)));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet("getMostSolds")]
    public IActionResult GetMostSolds()
    {
        return Ok(_repositories.TourReservations.FindWithPhoto()
            .Where(reservation => reservation.ArrivalDate >= DateTime.UtcNow.AddMonths(-1))
            .GroupBy(reservation => reservation.Offer.ProductId)
            .OrderBy(group => -group.Count())
            .Take(20)
            .Join(_repositories.Tours.Find(), group => group.Key, model => model.Id,
                (group, model) => TourDto.Map(model, _fileService.GetRelativePath(model.Image.Name, model.Image.Id),
                    model.Image.Name)));
    }
}