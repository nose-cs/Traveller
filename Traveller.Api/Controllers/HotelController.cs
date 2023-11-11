﻿using Microsoft.AspNetCore.Mvc;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Persistence.Repositories;

namespace Traveller.Controllers;

[ApiController]
[Route("[controller]")]
public class HotelController : ControllerBase
{
    private readonly HotelRepository _repository;
 
    private readonly ILogger<HotelController> _logger;

    public HotelController(ILogger<HotelController> logger, HotelRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpPost]
    public async Task<ActionResult> Create(HotelDto hotelDto)
    {
        try
        {
            await _repository.AddAsync(new Hotel()
                { Name = hotelDto.Name, Address = hotelDto.Address, Category = hotelDto.Category });
            
            await _repository.SaveChangesAsync();
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
            var dbHotel = await _repository.FindById(id);
            if (dbHotel is null)
            {
                return NotFound($"Hotel with id {id} doesn't exist");
            }

            dbHotel.Address = hotelDto.Address;
            dbHotel.Name = hotelDto.Name;
            dbHotel.Category = dbHotel.Category;
            
            await _repository.SaveChangesAsync();
            
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
            await _repository.Remove(id);
            await _repository.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<HotelDto>> GetAll() => Ok(_repository.Find().Select(HotelDto.Map));

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbHotel = await _repository.FindById(id);
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