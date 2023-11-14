﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Persistence.Migrations;
using Traveller.Persistence.Repositories;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TourOfferController : ControllerBase
{
    private readonly Repositories _repository;

    private readonly ILogger<TourOfferController> _logger;

    public TourOfferController(ILogger<TourOfferController> logger, Repositories repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpPost]
    [Authorize(Roles = ("MarketingEmployee"))]
    public async Task<ActionResult> Create(OfferDto offerDto)
    {
        if (await _repository.Tours.FindById(offerDto.ProductId) == null)
            return NotFound($"Tour id: {offerDto.ProductId} doesn´t exists");
        
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        TourOffer Offer = OfferDto.Map<Tour, TourReservation, TourOffer>(offerDto);

        Offer.Id = 0;

        Offer.AgencyId = agencyId;

        try
        {
            await _repository.TourOffers.AddAsync(Offer);
            
            await _repository.TourOffers.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
    
    [HttpPut]
    [Authorize(Roles = ("MarketingEmployee"))]
    public async Task<ActionResult> Update([FromBody] OfferDto offerDto)
    {
        try
        {
            var token = Request.Headers.Authorization[0]!.Substring(7);
            var jwt = new JwtSecurityToken(token);
            var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

            if (offerDto.Id == null)
                return BadRequest("Tour offer id can´t be null");

            var dbOffer = await _repository.TourOffers.FindById((int)offerDto.Id);
            if (dbOffer is null)
            {
                return NotFound($"Tour offer with id {offerDto.Id} doesn't exist");
            }

            if(dbOffer.AgencyId != agencyId)
            {
                return Unauthorized("Tour offer´s agency doesn´t match with user agency");
            }

            if(dbOffer.ProductId != offerDto.ProductId && await _repository.Tours.FindById(offerDto.ProductId) == null)
                return NotFound($"Tour id: {offerDto.ProductId} doesn´t exists");

            dbOffer = OfferDto.Map<Tour, TourReservation, TourOffer>(offerDto);
            
            await _repository.TourOffers.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
    
    [HttpDelete("{id:int}")]
    [Authorize(Roles = ("MarketingEmployee"))]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        var dbOffer = await _repository.TourOffers.FindById(id);
        if (dbOffer is null)
        {
            return NotFound($"Tour offer with id {id} doesn't exist");
        }

        if (dbOffer.AgencyId != agencyId)
        {
            return Unauthorized("Tour offer´s agency doesn´t match with user agency");
        }

        try
        {
            await _repository.TourOffers.Remove(id);
            await _repository.TourOffers.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<OfferDto>> GetAll() => Ok(_repository.TourOffers.Find().ToArray().Select(offer => {
                                                                                        var dto = OfferDto.Map<Tour, TourReservation, TourOffer>(offer);
                                                                                        dto.AgencyName = _repository.Agencies.GetName(offer.AgencyId);
                                                                                        dto.ProductName = _repository.Hotels.GetName(offer.ProductId);
                                                                                        return dto;
                                                                                    }).ToArray());

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbOffer = await _repository.TourOffers.FindById(id);
            if (dbOffer is null)
            {
                return NotFound($"Tour offer with id {id} doesn't exist");
            }

            var dto = OfferDto.Map<Tour, TourReservation, TourOffer>(dbOffer);
            dto.AgencyName = _repository.Agencies.GetName(dbOffer.AgencyId);
            dto.ProductName = _repository.Hotels.GetName(dbOffer.ProductId);

            return Ok(dto);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}