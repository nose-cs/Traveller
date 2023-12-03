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
    private readonly FileService _fileService;
    private readonly ILogger<TourOfferController> _logger;

    public PackageController(ILogger<TourOfferController> logger, Repositories repository,
        ExporterService exporterService, FileService fileService)
    {
        _logger = logger;
        _repository = repository;
        _exporterService = exporterService;
        _fileService = fileService;
    }

    [HttpPost]
    [Authorize(Roles = ("MarketingEmployee"))]
    public async Task<ActionResult> Create(PackageDto packageDto)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        packageDto.AgencyId = agencyId;

        var newPackage = PackageDto.Map(packageDto);
        newPackage.Facilities = new List<PackageFacility>();

        for (int i = 0; i < packageDto.FacilitiesIds.Length; i++)
        {
            var facility = await _repository.Facilities.FindById(packageDto.FacilitiesIds[i]);

            if (facility == null)
                return NotFound("Facility - id: " + packageDto.FacilitiesIds[i] + " not found");

            newPackage.Facilities.Add(new PackageFacility
                { Facility = facility, Package = newPackage, Price = packageDto.FacilitiesPrices[i] });
        }

        await _repository.Package.AddWithToursAsync(newPackage, packageDto.ToursIds);
        await _repository.Package.SaveChangesAsync();
        return Ok();
    }

    [HttpPut]
    [Authorize(Roles = ("MarketingEmployee"))]
    public async Task<ActionResult> Update([FromBody] PackageDto packageDto)
    {
        try
        {
            var token = Request.Headers.Authorization[0]!.Substring(7);
            var jwt = new JwtSecurityToken(token);
            var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

            if (!packageDto.Id.HasValue)
                return NotFound();

            var dbOffer = await _repository.Package.FindById(packageDto.Id.Value);
            if (dbOffer is null)
            {
                return NotFound();
            }

            if (dbOffer.AgencyId != agencyId)
            {
                return Unauthorized("Package offer´s agency doesn´t match with user agency");
            }

            dbOffer.Title = packageDto.Title;
            dbOffer.Duration = packageDto.Duration;
            dbOffer.Description = packageDto.Description;
            dbOffer.Price = packageDto.Price;
            dbOffer.Capacity = packageDto.Capacity;
            dbOffer.StartDate = packageDto.StartDate;
            dbOffer.EndDate = packageDto.EndDate;
            dbOffer.Capacity = packageDto.Capacity;
            dbOffer.ImageId = packageDto.ImageId;

            _repository.Package.RemoveAllPackageFacility(dbOffer.Id);

            if (dbOffer.Facilities == null)
                dbOffer.Facilities = new List<PackageFacility>();

            for (int i = 0; i < packageDto.FacilitiesIds.Length; i++)
            {
                var facility = await _repository.Facilities.FindById(packageDto.FacilitiesIds[i]);

                if (facility == null)
                    return NotFound("Facility - id: " + packageDto.FacilitiesIds[i] + " not found");

                dbOffer.Facilities.Add(new PackageFacility
                    { Facility = facility, Package = dbOffer, Price = packageDto.FacilitiesPrices[i] });
            }

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
    [Authorize(Roles = ("MarketingEmployee"))]
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
            && (filter.Title == null || pa.Title.ToLower().Contains(filter.Title.ToLower()))
            && (filter.StartPrice == null || pa.Price >= filter.StartPrice)
            && (filter.EndPrice == null || pa.Price <= filter.EndPrice)
            && (filter.Capacity == null || pa.Capacity >= filter.Capacity)
            && (filter.StartDate == null || pa.StartDate <= filter.StartDate && (pa.EndDate == null ||
                pa.EndDate >= filter.StartDate))
            && (filter.AgencyId == null || pa.AgencyId == filter.AgencyId));

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
                var dto = PackageDto.Map(offer, _fileService.GetRelativePath(offer.Image.Name, offer.Image.Id),
                    offer.Image.Name);
                dto.AgencyName = _repository.Agencies.GetName(offer.AgencyId);
                return dto;
            });

        return Ok(new PaginationResponse<PackageDto>() { TotalCollectionSize = offers.Count(), Items = pageOffers });
    }

    [HttpGet("getTours")]
    public IActionResult GetTours([FromQuery] int packageId)
    {
        return Ok(_repository.Package.FindTours(packageId).Select(x =>
            TourDto.Map(x, _fileService.GetRelativePath(x.Image.Name, x.Image.Id), x.Image.Name)));
    }

    [HttpGet("getPackageFacilities")]
    public IActionResult GetPackageFacilities([FromQuery] int packageId)
    {
        return Ok(_repository.Package.FindFacilities(packageId).Select(PackageFacilityDto.Map));
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

            var dto = PackageDto.Map(dbOffer, _fileService.GetRelativePath(dbOffer.Image.Name, dbOffer.Image.Id),
                dbOffer.Image.Name);
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

        var response = _repository.PackageReservations.FindWithInclude(reservation => reservation.Offer).Where(
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
                "Package Offer Sales (" + request.Start.ToString() + " - " + request.End.ToString() + ")",
                new[] { "Id", "Title", "Total Sales", "Amount (USD)" },
                new float[] { 15, 50, 15, 15 },
                response.SelectMany(sales => new object[]
                    { sales.Group, sales.Description!, sales.Total, sales.MoneyAmount }),
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
            .Select(group => PackageDto.Map(group.First().Offer,
                _fileService.GetRelativePath(group.First().Offer.Image.Name, group.First().Offer.Image.Id),
                group.First().Offer.Image.Name)));
    }
}