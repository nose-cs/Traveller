using Microsoft.AspNetCore.Mvc;
using Traveller.Domain;
using Traveller.Domain.Models;
using Traveller.Dtos;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FlightController : ControllerBase
{
    private readonly Repositories _repositories;

    private readonly ILogger<HotelController> _logger;

    public FlightController(ILogger<HotelController> logger, Repositories repositories)
    {
        _logger = logger;
        _repositories = repositories;
    }

    [HttpPost]
    public async Task<ActionResult> Create(FlightDto flightDto)
    {
        try
        {
            await _repositories.Flights.AddAsync(FlightDto.Map(flightDto));

            await _repositories.Flights.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Update([FromBody] FlightDto flightDto, [FromRoute] int id)
    {
        try
        {
            var dbFlight = await _repositories.Flights.FindById(id);
            if (dbFlight is null)
            {
                return NotFound($"Flight with id {id} doesn't exist");
            }

            dbFlight.FlightNumber = flightDto.FlightNumber;
            dbFlight.Airline = flightDto.Airline;
            dbFlight.DestinationId = flightDto.Destination.Id;
            dbFlight.SourceId = flightDto.Source.Id;

            await _repositories.Flights.SaveChangesAsync();

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
            await _repositories.Flights.Remove(id);
            await _repositories.Flights.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbFlight = await _repositories.Flights.FindById(id);
            if (dbFlight is null)
            {
                return NotFound($"Flight with id {id} doesn't exist");
            }

            return Ok(FlightDto.Map(dbFlight));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<FlightDto>> Get([FromQuery] FlightFilterDTO filter)
    {
        var items = _repositories.Flights.Find().Where(fl =>
                   (filter.Id is null || fl.Id == filter.Id)
                && (filter.FlightNumber is null || fl.FlightNumber.ToString().Contains(filter.FlightNumber.ToString()!))
                && (filter.Airline is null || fl.Airline.ToLower().Contains(filter.Airline.ToLower()))
                && (filter.Source is null || fl.Source.Address.ToLower().Contains(filter.Source.ToLower())
                                          || fl.Source.City.ToLower().Contains(filter.Source.ToLower())
                                          || fl.Source.Country.ToLower().Contains(filter.Source.ToLower()))
                && (filter.Destination is null || fl.Destination.Address.ToLower().Contains(filter.Destination.ToLower())
                                               || fl.Destination.Country.ToLower().Contains(filter.Destination.ToLower())
                                               || fl.Destination.City.ToLower().Contains(filter.Destination.ToLower())));

        if (filter.OrderBy != null)
        {
            switch (filter.OrderBy)
            {
                case ("FlightNumber"):
                    items = items.OrderBy(item => item.FlightNumber); break;
                case ("Airline"):
                    items = items.OrderBy(item => item.Airline); break;
                default:
                    items = items.OrderBy(item => item.Id); break;
            }
        }

        if (filter.Descending.HasValue && filter.Descending.Value)
            items = items.Reverse();
        
        var pageItems = (filter.PageIndex == null || filter.PageSize == null ? items : items.Take(new Range((filter.PageIndex.Value - 1) * filter.PageSize.Value, (filter.PageIndex.Value - 1) * filter.PageSize.Value + filter.PageSize.Value)))
        .Select(FlightDto.Map);

        return Ok(new PaginationResponse<FlightDto>() { TotalCollectionSize = items.Count(), Items = pageItems });
    }       

    [HttpGet("getMostSolds")]
    public IActionResult GetMostSolds()
    {
        return Ok(_repositories.FlightReservations.FindWithInclude(reservation => reservation.Offer)
                                       .Where(reservation => reservation.ArrivalDate >= DateTime.UtcNow.AddMonths(-1))
                                       .GroupBy(reservation => reservation.Offer.ProductId)
                                       .OrderBy(group => -group.Count())
                                       .Take(20)
                                       .Join(_repositories.Flights.Find(), group => group.Key, model => model.Id, (group, model) => FlightDto.Map(model)));
    }
}