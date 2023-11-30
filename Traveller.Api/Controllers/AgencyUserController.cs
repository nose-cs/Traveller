using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Exceptions;
using Traveller.Services;

namespace Traveller.Controllers;

public partial class AgencyController
{

    private readonly LoginService _loginService;

    [HttpPost("{id:int}/register")]
    [AllowAnonymous]
    public async Task<IActionResult> RegisterUser([FromBody]UserDto userDto, [FromRoute]int id)
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
    [AllowAnonymous]
    public IActionResult GetUsers(int id)
    {
        //TODO authorize
        return Ok(_repositories.Users.FindAgencyUsers().Where(u => u.AgencyId == id));
    }
    
    [HttpGet("{idAgency:int}/employees/{idUser:int}/reservations")]
    public IActionResult GetUserReservations([FromRoute] int idAgency, [FromRoute] int idUser)
    {
        //TODO
        return Ok();
    }
}