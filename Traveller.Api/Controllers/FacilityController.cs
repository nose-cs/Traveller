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
public class FacilityController : ControllerBase
{
    private readonly Repositories _repository;
    private readonly ILogger<TourOfferController> _logger;

    public FacilityController(ILogger<TourOfferController> logger, Repositories repository, ExporterService exporterService)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetFacilities([FromQuery] FacilityFilterDto filter)
    {
        var fs = _repository.Facilities.Find().Where(f =>
            (filter.Id == null || f.Id == filter.Id)
            && (filter.Name == null || f.Name.ToLower().Contains(filter.Name.ToLower()))
            && (filter.Description == null || f.Description.ToLower().Contains(filter.Description)));

        if (filter.OrderBy != null)
        {
            switch (filter.OrderBy)
            {
                case ("Name"):
                    fs = fs.OrderBy(offer => offer.Name); break;
                default:
                    fs = fs.OrderBy(offer => offer.Id); break;
            }
        }

        if (filter.Descending.HasValue && filter.Descending.Value)
            fs = fs.Reverse();

        var pagefs = (filter.PageIndex == null || filter.PageSize == null ? fs : fs.Take(new Range((filter.PageIndex.Value - 1) * filter.PageSize.Value, (filter.PageIndex.Value - 1) * filter.PageSize.Value + filter.PageSize.Value)))
                               .ToArray().Select(f => new FacilityDto(f.Id, f.Name, f.Description));
                              

        return Ok(new PaginationResponse<FacilityDto>() { TotalCollectionSize = fs.Count(), Items = pagefs });
    }
}