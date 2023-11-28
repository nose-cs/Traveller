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

    [HttpGet]
    public ActionResult<IEnumerable<FlightDto>> GetAll() => Ok(_repositories.Flights.Find().Select(FlightDto.Map));

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
    
    [HttpGet("{id:int}/offers")]
    public IActionResult GetFlightOffers([FromRoute] int id, [FromQuery] OfferFilterDTO filter)
    {
        var offers = _repositories.FlightOffers.Find().Where(
                to => to.ProductId == id
                && (filter.StartPrice == null || to.Price >= filter.StartPrice)
                && (filter.EndPrice == null || to.Price <= filter.EndPrice)
                && (filter.StartDate == null || to.StartDate <= filter.StartDate && (to.EndDate == null || to.EndDate >= filter.StartDate))
                && (filter.AgencyId == null || to.AgencyId == filter.AgencyId))
            .ToArray().Select(offer =>
            {
                var dto = OfferDto.Map<Flight, FlightReservation, FlightOffer>(offer);
                dto.AgencyName = _repositories.Agencies.GetName(offer.AgencyId);
                dto.ProductName = _repositories.Flights.GetName(offer.ProductId);
                return dto;
            });
        return Ok(offers);
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