using System.IdentityModel.Tokens.Jwt;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveller.Domain;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Exceptions;
using Traveller.Services;

namespace Traveller.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = ("TravellerAdmin"))]
public class AdminController : ControllerBase
{
    private readonly LoginService _loginService;
    private readonly ILogger<HotelController> _logger;
    private readonly Repositories _repositories;

    public AdminController(LoginService loginService, ILogger<HotelController> logger, Repositories repositories)
    {
        _loginService = loginService;
        _logger = logger;
        _repositories = repositories;
    }

    [HttpPost("registerTravellerAdmin")]
    public async Task<ActionResult> RegisterTravellerAdmin([FromBody] UserDto userDto)
    {
        var token = Request.Headers.Authorization[0]![7..];
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        try
        {
            await _loginService.CreateAccount(userDto, agencyId);
            return Ok();
        }
        catch (BadRequestException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpGet("AgenciesUsers")]
    public IActionResult GetUsers([FromQuery] PaginationDto filter)
    {
        IEnumerable<AgencyUser> items = _repositories.Users.FindAgencyUsers();

        if (filter.OrderBy != null)
        {
            switch (filter.OrderBy)
            {
                case ("Name"):
                    items = items.OrderBy(item => item.Name); break;
                case ("Email"):
                    items = items.OrderBy(item => item.Email); break;
                case ("AgencyId"):
                    items = items.OrderBy(item => item.AgencyId); break;
                default:
                    items = items.OrderBy(item => item.Id); break;
            }
        }

        if (filter.Descending.HasValue && filter.Descending.Value)
            items = items.Reverse();

        var pageItems = (filter.PageIndex == null || filter.PageSize == null ? items : items.Take(new Range((filter.PageIndex.Value - 1) * filter.PageSize.Value, (filter.PageIndex.Value - 1) * filter.PageSize.Value + filter.PageSize.Value)));

        return Ok(new PaginationResponse<AgencyUser>() { TotalCollectionSize = items.Count(), Items = pageItems });
    }
}