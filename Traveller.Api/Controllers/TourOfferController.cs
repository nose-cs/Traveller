using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Traveller.Domain;
using Traveller.Domain.Models;
using Traveller.Dtos;

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

        var offer = new TourOffer();
        OfferDto.Map<Tour, TourReservation, TourOffer>(offer, offerDto);

        offer.Id = 0;

        offer.AgencyId = agencyId;

        try
        {
            await _repository.TourOffers.AddAsync(offer);

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

            if (dbOffer.AgencyId != agencyId)
            {
                return Unauthorized("Tour offer´s agency doesn´t match with user agency");
            }

            if (dbOffer.ProductId != offerDto.ProductId && await _repository.Tours.FindById(offerDto.ProductId) == null)
                return NotFound($"Tour id: {offerDto.ProductId} doesn´t exists");

            OfferDto.Map<Tour, TourReservation, TourOffer>(dbOffer, offerDto);

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
    public ActionResult<IEnumerable<OfferDto>> GetAll() => Ok(_repository.TourOffers.Find().ToArray().Select(offer =>
    {
        var dto = OfferDto.Map<Tour, TourReservation, TourOffer>(offer);
        dto.AgencyName = _repository.Agencies.GetName(offer.AgencyId);
        dto.ProductName = _repository.Tours.GetName(offer.ProductId);
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
            dto.ProductName = _repository.Tours.GetName(dbOffer.ProductId);

            return Ok(dto);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet("getTourOffers")]
    public IActionResult GetTourOffers([FromQuery] OfferFilterDTO filter)
    {
        var offers = _repository.TourOffers.Find().Where(to =>
                (filter.ProductId == null || to.Product.Id == filter.ProductId)
                && (filter.StartPrice == null || to.Price >= filter.StartPrice)
                && (filter.EndPrice == null || to.Price <= filter.EndPrice)
                && (filter.StartDate == null ||
                    to.StartDate <= filter.StartDate && (to.EndDate == null ||
                                                         to.EndDate >= filter.StartDate))
                && (filter.AgencyId == null || to.Agency.Id == filter.AgencyId))
            .ToArray().Select(offer =>
            {
                var dto = OfferDto.Map<Tour, TourReservation, TourOffer>(offer);
                dto.AgencyName = _repository.Agencies.GetName(offer.AgencyId);
                dto.ProductName = _repository.Tours.GetName(offer.ProductId);
                return dto;
            });
        return Ok(offers);
    }
}