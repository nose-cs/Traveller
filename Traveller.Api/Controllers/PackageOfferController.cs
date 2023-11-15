using Microsoft.AspNetCore.Authorization;
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
public class PackageOfferController : ControllerBase
{
    private readonly Repositories _repository;

    private readonly ILogger<TourOfferController> _logger;

    public PackageOfferController(ILogger<TourOfferController> logger, Repositories repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpPost]
    [Authorize(Roles = ("MarketingEmployee"))]
    public async Task<ActionResult> Create(OfferDto offerDto)
    {
        if (await _repository.Packages.FindById(offerDto.ProductId) == null)
            return NotFound($"Package id: {offerDto.ProductId} doesn´t exists");
        
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        PackageOffer Offer = new PackageOffer(); 
        OfferDto.Map<Package, PackageReservation, PackageOffer>(Offer, offerDto);

        Offer.Id = 0;

        Offer.AgencyId = agencyId;

        try
        {
            await _repository.PackageOffers.AddAsync(Offer);
            
            await _repository.PackageOffers.SaveChangesAsync();
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
                return BadRequest("Package offer id can´t be null");

            var dbOffer = await _repository.PackageOffers.FindById((int)offerDto.Id);
            if (dbOffer is null)
            {
                return NotFound($"Package offer with id {offerDto.Id} doesn't exist");
            }

            if(dbOffer.AgencyId != agencyId)
            {
                return Unauthorized("Package offer´s agency doesn´t match with user agency");
            }

            if(dbOffer.ProductId != offerDto.ProductId && await _repository.Packages.FindById(offerDto.ProductId) == null)
                return NotFound($"Package id: {offerDto.ProductId} doesn´t exists");

            OfferDto.Map<Package, PackageReservation, PackageOffer>(dbOffer, offerDto);
            
            await _repository.PackageOffers.SaveChangesAsync();
            
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

        var dbOffer = await _repository.PackageOffers.FindById(id);
        if (dbOffer is null)
        {
            return NotFound($"Package offer with id {id} doesn't exist");
        }

        if (dbOffer.AgencyId != agencyId)
        {
            return Unauthorized("Package offer´s agency doesn´t match with user agency");
        }

        try
        {
            await _repository.PackageOffers.Remove(id);
            await _repository.PackageOffers.SaveChangesAsync();
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<OfferDto>> GetAll() => Ok(_repository.PackageOffers.Find().ToArray().Select(offer => {
                                                                                        var dto = OfferDto.Map<Package, PackageReservation, PackageOffer>(offer);
                                                                                        dto.AgencyName = _repository.Agencies.GetName(offer.AgencyId);
                                                                                        dto.ProductName = _repository.Hotels.GetName(offer.ProductId);
                                                                                        return dto;
                                                                                    }).ToArray());

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbOffer = await _repository.PackageOffers.FindById(id);
            if (dbOffer is null)
            {
                return NotFound($"Package offer with id {id} doesn't exist");
            }

            var dto = OfferDto.Map<Package, PackageReservation, PackageOffer>(dbOffer);
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