using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Traveller.Domain;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Services;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FlightOfferController : ControllerBase
{
    private readonly FileService _fileService;
    private readonly Repositories _repository;
    private readonly ExporterService _exporterService;

    private readonly ILogger<FlightOfferController> _logger;

    public FlightOfferController(ILogger<FlightOfferController> logger, Repositories repository,
        ExporterService exporterService, FileService fileService)
    {
        _logger = logger;
        _repository = repository;
        _exporterService = exporterService;
        _fileService = fileService;
    }

    [HttpPost]
    [Authorize(Roles = ("MarketingEmployee"))]
    public async Task<ActionResult> Create(OfferDto offerDto)
    {
        if (await _repository.Flights.FindById(offerDto.ProductId) == null)
            return NotFound($"Flight id: {offerDto.ProductId} doesn´t exists");

        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        var offer = new FlightOffer();
        OfferDto.Map<Flight, FlightReservation, FlightOffer>(offer, offerDto);

        offer.Id = 0;

        offer.AgencyId = agencyId;

        try
        {
            await _repository.FlightOffers.AddAsync(offer);

            await _repository.FlightOffers.SaveChangesAsync();
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
                return BadRequest("Flight offer id can´t be null");

            var dbOffer = await _repository.FlightOffers.FindById((int)offerDto.Id);
            if (dbOffer is null)
            {
                return NotFound($"Flight offer with id {offerDto.Id} doesn't exist");
            }

            if (dbOffer.AgencyId != agencyId)
            {
                return Unauthorized("Flight offer´s agency doesn´t match with user agency");
            }

            if (dbOffer.ProductId != offerDto.ProductId &&
                await _repository.Flights.FindById(offerDto.ProductId) == null)
                return NotFound($"Flight id: {offerDto.ProductId} doesn´t exists");

            OfferDto.Map<Flight, FlightReservation, FlightOffer>(dbOffer, offerDto);

            await _repository.FlightOffers.SaveChangesAsync();

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

        var dbOffer = await _repository.FlightOffers.FindById(id);
        if (dbOffer is null)
        {
            return NotFound($"Flight offer with id {id} doesn't exist");
        }

        if (dbOffer.AgencyId != agencyId)
        {
            return Unauthorized("Flight offer´s agency doesn´t match with user agency");
        }

        try
        {
            await _repository.FlightOffers.Remove(id);
            await _repository.FlightOffers.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    public IActionResult GetFlightOffers([FromQuery] OfferFilterDTO filter)
    {
        var offers = _repository.FlightOffers.Find().Where(ho =>
            (filter.ProductId == null || ho.ProductId == filter.ProductId)
            && (filter.Title == null || ho.Title.ToLower().Contains(filter.Title.ToLower()))
            && (filter.StartPrice == null || ho.Price >= filter.StartPrice)
            && (filter.EndPrice == null || ho.Price <= filter.EndPrice)
            && (filter.Capacity == null || ho.Capacity >= filter.Capacity)
            && (filter.StartDate == null || ho.StartDate <= filter.StartDate && (ho.EndDate == null ||
                ho.EndDate >= filter.StartDate))
            && (filter.AgencyId == null || ho.AgencyId == filter.AgencyId));

        if (filter.OrderBy != null)
        {
            switch (filter.OrderBy)
            {
                case ("Price"):
                    offers = offers.OrderBy(offer => offer.Price);
                    break;
                default:
                    offers = offers.OrderBy(offer => offer.Id);
                    break;
            }
        }

        if (filter.Descending.HasValue && filter.Descending.Value)
            offers = offers.Reverse();

        var pageOffers = (filter.PageIndex == null || filter.PageSize == null
                ? offers
                : offers.Take(new Range((filter.PageIndex.Value - 1) * filter.PageSize.Value,
                    (filter.PageIndex.Value - 1) * filter.PageSize.Value + filter.PageSize.Value)))
            .ToArray().Select(offer =>
            {
                var dto = OfferDto.Map<Flight, FlightReservation, FlightOffer>(offer,
                    _fileService.GetRelativePath(offer.Image.Name, offer.Image.Id),
                    offer.Image.Name);
                dto.AgencyName = _repository.Agencies.GetName(offer.AgencyId);
                dto.ProductName = _repository.Flights.GetName(offer.ProductId);
                return dto;
            });

        return Ok(new PaginationResponse<OfferDto>() { TotalCollectionSize = offers.Count(), Items = pageOffers });
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbOffer = await _repository.FlightOffers.FindById(id);
            if (dbOffer is null)
            {
                return NotFound($"Flight offer with id {id} doesn't exist");
            }

            var dto = OfferDto.Map<Flight, FlightReservation, FlightOffer>(dbOffer,
                _fileService.GetRelativePath(dbOffer.Image.Name, dbOffer.Image.Id), dbOffer.Image.Name);
            dto.AgencyName = _repository.Agencies.GetName(dbOffer.AgencyId);
            dto.ProductName = _repository.Flights.GetName(dbOffer.ProductId);

            return Ok(dto);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet("getSales")]
    [Authorize(Roles = ("MarketingEmployee, Admin"))]
    public ActionResult GetSales([FromQuery] SalesRequest request, [FromQuery] ExportType? export)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        var response = _repository.FlightReservations.FindWithInclude(reservation => reservation.Offer).Where(
                reservation => reservation.Offer.AgencyId == agencyId &&
                               DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start &&
                               DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
            .GroupBy(reservation => reservation.OfferId)
            .OrderBy(group => group.Key)
            .Select(group => new SalesResponse
            {
                Group = group.Key.ToString(),
                Description = group.First().Offer.Title,
                Total = group.Count(),
                MoneyAmount = group.Sum(reservation => reservation.Price)
            });

        if (export.HasValue)
        {
            return Ok(_exporterService.getDoc(
                "Flight Offer Sales (" + request.Start.ToString() + " - " + request.End.ToString() + ")",
                new string[4] { "Id", "Title", "Total Sales", "Amount (USD)" },
                new float[4] { 15, 50, 15, 15 },
                response.SelectMany(sales => new object[]
                    { sales.Group, sales.Description!, sales.Total, sales.MoneyAmount }),
                export.Value
            ));
        }

        return Ok(response);
    }
}