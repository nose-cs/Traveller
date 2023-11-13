﻿using Microsoft.AspNetCore.Mvc;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Dtos;
using Traveller.Persistence.Repositories;

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
            return BadRequest(e.Message);
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
            dbFlight.Destination = flightDto.Destination;
            dbFlight.Source = flightDto.Source;
            
            await _repositories.Flights.SaveChangesAsync();
            
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
            await _repositories.Flights.Remove(id);
            await _repositories.Flights.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
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
            return BadRequest(e.Message);
        }
    }
}