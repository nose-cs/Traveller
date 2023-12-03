using System.IdentityModel.Tokens.Jwt;
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
    public IActionResult GetUsers()
    {
        return Ok(_repositories.Users.FindAgencyUsers());
    }
}