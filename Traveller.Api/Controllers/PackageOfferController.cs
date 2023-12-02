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
public class PackageController : ControllerBase
{
    private readonly Repositories _repository;
    private readonly ExporterService _exporterService;

    private readonly ILogger<TourOfferController> _logger;

    public PackageController(ILogger<TourOfferController> logger, Repositories repository, ExporterService exporterService)
    {
        _logger = logger;
        _repository = repository;
        _exporterService = exporterService;
    }

    [HttpPost]
    // [Authorize(Roles = ("MarketingEmployee"))]
    public async Task<ActionResult> Create(PackageDto packageDto)
    {
        // var token = Request.Headers.Authorization[0]!.Substring(7);
        // var jwt = new JwtSecurityToken(token);
        // var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);
        //
        // if (packageDto.AgencyId != agencyId)
        //     return Unauthorized("Package offer´s agency doesn´t match with user agency");
        //
        var newPackage = PackageDto.Map(packageDto);
        
        foreach (var tourId in packageDto.ToursIds)
        {
            var tour = await _repository.Tours.FindById(tourId);
            
            if (tour == null)
                return NotFound($"Tour id: {tourId} doesn´t exists");
            
            newPackage.Tours.Add(tour);
        }

        foreach (var facilityId in packageDto.FacilitiesIds)
        {
            var facility = await _repository.Facilities.FindById(facilityId);

            if (facility == null)
                return NotFound("Facility - id: " + facilityId + " not found");

            newPackage.Facilities.Add(new PackageFacility{Facility = facility});
        }

        await _repository.Package.AddAsync(newPackage);
        await _repository.Package.SaveChangesAsync();
        return Ok();
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
                return BadRequest("Package id can´t be null");

            var dbOffer = await _repository.Package.FindById((int)offerDto.Id);
            if (dbOffer is null)
            {
                return NotFound();
            }

            if (dbOffer.AgencyId != agencyId)
            {
                return Unauthorized("Package offer´s agency doesn´t match with user agency");
            }

            // if (dbOffer.ProductId != offerDto.ProductId &&
            //     await _repository.Packages.FindById(offerDto.ProductId) == null)
            //     return NotFound($"Package id: {offerDto.ProductId} doesn´t exists");
            //
            // OfferDto.Map<Package, PackageReservation, Package>(dbOffer, offerDto);

            await _repository.Package.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpDelete("{id:int}")]
    // [Authorize(Roles = ("MarketingEmployee"))]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        var dbOffer = await _repository.Package.FindById(id);
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
            await _repository.Package.Remove(id);
            await _repository.Package.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    public IActionResult GetPackageOffers([FromQuery] OfferFilterDTO filter)
    {
        var offers = _repository.Package.Find().Where(pa =>
                (filter.ProductId == null || pa.Id == filter.ProductId)
                && (filter.StartPrice == null || pa.Price >= filter.StartPrice)
                && (filter.EndPrice == null || pa.Price <= filter.EndPrice)
                && (filter.StartDate == null || pa.StartDate <= filter.StartDate
                    && (pa.EndDate == null || pa.EndDate >= filter.StartDate))
                && (filter.AgencyId == null || pa.AgencyId == filter.AgencyId)
               ).ToArray().Select(offer =>
            {
                var dto = PackageDto.Map(offer);
                dto.AgencyName = _repository.Agencies.GetName(offer.AgencyId);
                return dto;
            });
        return Ok(offers);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbOffer = await _repository.Package.FindById(id);
            if (dbOffer is null)
            {
                return NotFound($"Package offer with id {id} doesn't exist");
            }

            var dto = PackageDto.Map(dbOffer);
            dto.AgencyName = _repository.Agencies.GetName(dbOffer.AgencyId);
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

        var response = _repository.PackageReservations.FindWithInclude(reservation => reservation.Offer).Where(reservation => reservation.Offer.AgencyId == agencyId && DateOnly.FromDateTime(reservation.ArrivalDate) >= request.Start && DateOnly.FromDateTime(reservation.ArrivalDate) <= request.End)
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
            return Ok(_exporterService.getDoc("Package Offer Sales (" + request.Start.ToString() + " - " + request.End.ToString() + ")",
                                                       new[] { "Id", "Title", "Total Sales", "Amount (USD)" },
                                                       new float[] { 15, 50, 15, 15 },
                                                       response.SelectMany(sales => new object[] { sales.Group, sales.Description!, sales.Total, sales.MoneyAmount }),
                                                       export.Value
                                                       ));
        }

        return Ok(response);
    }

    [HttpGet("getMostSolds")]
    public IActionResult GetMostSolds()
    {
        return Ok(_repository.PackageReservations.FindWithInclude(reservation => reservation.Offer)
                                       .Where(reservation => reservation.ArrivalDate >= DateTime.UtcNow.AddMonths(-1))
                                       .GroupBy(reservation => reservation.OfferId)
                                       .OrderBy(group => -group.Count())
                                       .Take(20)
                                       .Select(group => PackageDto.Map(group.First().Offer)));
    }
}