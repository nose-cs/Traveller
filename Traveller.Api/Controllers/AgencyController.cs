using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveller.Domain;
using Traveller.Dtos;
using Traveller.Services;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
// [Authorize(Roles = ("AgencyAdmin, TravellerAdmin"))]
public partial class AgencyController : ControllerBase
{
    private readonly Repositories _repositories;

    private readonly ILogger<HotelController> _logger;

    public AgencyController(Repositories repositories, ILogger<HotelController> logger, LoginService loginService)
    {
        _repositories = repositories;
        _logger = logger;
        _loginService = loginService;
    }
    
    [HttpPost]
    public async Task<ActionResult> Create(AgencyDto agencyDto)
    {
        try
        {
            await _repositories.Agencies.AddAsync(AgencyDto.Map(agencyDto));

            await _repositories.Agencies.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Update([FromBody] AgencyDto agencyDto, [FromRoute] int id)
    {
        try
        {
            var dbAgency = await _repositories.Agencies.FindById(id);
            if (dbAgency is null)
            {
                return NotFound($"Agency with id {id} doesn't exist");
            }

            dbAgency.Name = agencyDto.Name;
            dbAgency.Fax = agencyDto.Fax;
            dbAgency.Email = agencyDto.Email;
            dbAgency.Address.Address = agencyDto.Address.Address;
            dbAgency.Address.City = agencyDto.Address.City;
            dbAgency.Address.Country = agencyDto.Address.Country;
            
            await _repositories.Agencies.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
        try
        {
            await _repositories.Agencies.Remove(id);
            await _repositories.Agencies.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<AgencyDto>> GetAll([FromQuery] PaginationDto filter)
    {
        var items = _repositories.Agencies.Find();

        if (filter.OrderBy != null)
        {
            switch (filter.OrderBy)
            {
                case ("Name"):
                    items = items.OrderBy(item => item.Name); break;
                case ("Email"):
                    items = items.OrderBy(item => item.Email); break;
                default:
                    items = items.OrderBy(item => item.Id); break;
            }
        }

        if (filter.Descending.HasValue && filter.Descending.Value)
            items = items.Reverse();

        var pageItems = (filter.PageIndex == null || filter.PageSize == null ? items : items.Take(new Range((filter.PageIndex.Value - 1) * filter.PageSize.Value, (filter.PageIndex.Value - 1) * filter.PageSize.Value + filter.PageSize.Value)))
        .Select(AgencyDto.Map);

        return Ok(new PaginationResponse<AgencyDto>() { TotalCollectionSize = items.Count(), Items = pageItems });
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbAgency = await _repositories.Agencies.FindById(id);
            if (dbAgency is null)
            {
                return NotFound($"Agency with id {id} doesn't exist");
            }

            return Ok(AgencyDto.Map(dbAgency));
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}