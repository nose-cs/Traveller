using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Traveller.Domain;
using Traveller.Domain.Models;
using Traveller.Dtos;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelOfferController : ControllerBase
{
    private readonly Repositories _repository;

    private readonly ILogger<HotelOfferController> _logger;

    public HotelOfferController(ILogger<HotelOfferController> logger, Repositories repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpPost]
    [Authorize(Roles = ("MarketingEmployee"))]
    public async Task<ActionResult> Create(OfferDto offerDto)
    {
        if (await _repository.Hotels.FindById(offerDto.ProductId) == null)
            return NotFound($"Hotel id: {offerDto.ProductId} doesn´t exists");

        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        HotelOffer hotelOffer = new HotelOffer();
        OfferDto.Map<Hotel, HotelReservation, HotelOffer>(hotelOffer, offerDto);

        hotelOffer.Id = 0;

        hotelOffer.AgencyId = agencyId;

        try
        {
            await _repository.HotelOffers.AddAsync(hotelOffer);

            await _repository.HotelOffers.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
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
                return BadRequest("Hotel offer id can´t be null");

            var dbHotelOffer = await _repository.HotelOffers.FindById((int)offerDto.Id);
            if (dbHotelOffer is null)
            {
                return NotFound($"Hotel offer with id {offerDto.Id} doesn't exist");
            }

            if (dbHotelOffer.AgencyId != agencyId)
            {
                return Unauthorized("Hotel offer´s agency doesn´t match with user agency");
            }

            if (dbHotelOffer.ProductId != offerDto.ProductId &&
                await _repository.Hotels.FindById(offerDto.ProductId) == null)
                return NotFound($"Hotel id: {offerDto.ProductId} doesn´t exists");

            OfferDto.Map<Hotel, HotelReservation, HotelOffer>(dbHotelOffer, offerDto);

            await _repository.HotelOffers.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpDelete("{id:int}")]
    [Authorize(Roles = ("MarketingEmployee"))]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        var dbHotelOffer = await _repository.HotelOffers.FindById(id);
        if (dbHotelOffer is null)
        {
            return NotFound($"Hotel offer with id {id} doesn't exist");
        }

        if (dbHotelOffer.AgencyId != agencyId)
        {
            return Unauthorized("Hotel offer´s agency doesn´t match with user agency");
        }

        try
        {
            await _repository.HotelOffers.Remove(id);
            await _repository.HotelOffers.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [AllowAnonymous]
    [HttpGet]
    public ActionResult<IEnumerable<OfferDto>> GetAll() => Ok(_repository.HotelOffers.Find().ToArray().Select(offer =>
    {
        var dto = OfferDto.Map<Hotel, HotelReservation, HotelOffer>(offer);
        dto.AgencyName = _repository.Agencies.GetName(offer.AgencyId);
        dto.ProductName = _repository.Hotels.GetName(offer.ProductId);
        return dto;
    }).ToArray());

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbHotelOffer = await _repository.HotelOffers.FindById(id);
            if (dbHotelOffer is null)
            {
                return NotFound($"Hotel offer with id {id} doesn't exist");
            }

            var dto = OfferDto.Map<Hotel, HotelReservation, HotelOffer>(dbHotelOffer);
            dto.AgencyName = _repository.Agencies.GetName(dbHotelOffer.AgencyId);
            dto.ProductName = _repository.Hotels.GetName(dbHotelOffer.ProductId);

            return Ok(dto);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet("GetHotelsWithFilter")]
    public IActionResult GetHotelOffers([FromQuery] OfferFilterDTO filter)
    {
        var offers = _repository.HotelOffers.Find().Where(ho =>
             (filter.ProductId == null || ho.ProductId == filter.ProductId)   
            && (filter.StartPrice == null || ho.Price >= filter.StartPrice)
            && (filter.EndPrice == null || ho.Price <= filter.EndPrice)
            && (filter.StartDate == null ||
                ho.StartDate <= filter.StartDate && (ho.EndDate == null ||
                                                     ho.EndDate >= filter.StartDate))
             && (filter.objectName == null || string.Equals(ho.Product.Name, filter.objectName,
                StringComparison.CurrentCultureIgnoreCase))).ToArray().Select(offer =>
        {
            var dto = OfferDto.Map<Hotel, HotelReservation, HotelOffer>(offer);
            dto.AgencyName = _repository.Agencies.GetName(offer.AgencyId);
            dto.ProductName = _repository.Hotels.GetName(offer.ProductId);
            return dto;
        });
        return Ok(offers);
    }
}