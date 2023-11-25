using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
using Traveller.Domain;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Exceptions;
using Traveller.Services;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AgencyController : ControllerBase
{
    private readonly Repositories _repositories;

    private readonly ILogger<HotelController> _logger;
    private readonly LoginService _loginService;

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
    public ActionResult<IEnumerable<FlightDto>> GetAll() => Ok(_repositories.Flights.Find().Select(FlightDto.Map));

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

    [HttpPost("{id:int}/register")]
    public async Task<IActionResult> RegisterUser(UserDto userDto, int id)
    {
        var token = Request.Headers.Authorization[0]![7..];
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);
        
        if (agencyId != id || userDto.Role is not (Role.AgencyAdmin or Role.Agent or Role.MarketingEmployee)) 
            return Unauthorized("You don't have permission for this action");

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
    
    [HttpPost("{idAgency:int}/employees/{idUser:int}")]
    public async Task<IActionResult> UpdateUser(UserDto userDto, int idUser, int idAgency)
    {
        try
        {
            var token = Request.Headers.Authorization[0]![7..];
            var jwt = new JwtSecurityToken(token);
            var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);
        
            if (agencyId != idAgency || userDto.Role is not (Role.AgencyAdmin or Role.Agent or Role.MarketingEmployee)) 
                return Unauthorized("You don't have permission for this action");
            
            var dbUser = await _repositories.Users.FindById(idUser);
            if (dbUser is AgencyUser agencyUser && agencyUser.AgencyId != idAgency || dbUser is null)
            {
                return NotFound($"User with id {idUser} doesn't exist in agency {idAgency}");
            }
            
            dbUser.Email = userDto.Email;
            dbUser.Password = userDto.Password;
            dbUser.Role = userDto.Role;
            dbUser.Name = userDto.Name;
            
            await _repositories.Hotels.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpGet("{id:int}/employees")]
    public IActionResult GetUsers(int id)
    {
        //TODO
        return Ok();
    }
    
    [HttpGet("{idAgency:int}/employees/{idUser:int}/reservations")]
    public IActionResult GetUserReservations([FromRoute] int idAgency, [FromRoute] int idUser)
    {
        //TODO
        return Ok();
    }
}