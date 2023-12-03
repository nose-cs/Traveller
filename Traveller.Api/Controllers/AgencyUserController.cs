using System.IdentityModel.Tokens.Jwt;
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
    public async Task<IActionResult> RegisterUser([FromBody]UserDto userDto, [FromRoute]int id)
    {
        var token = Request.Headers.Authorization[0]![7..];
        var jwt = new JwtSecurityToken(token);

        if (int.TryParse(jwt.Claims.First(c => c.Type == "agencyId").Value, out var agencyId)
            && agencyId != id)
        {
            return Unauthorized("You don't have permission for this action");
        }
        
        
        if (userDto.Role is not (Role.AgencyAdmin or Role.Agent or Role.MarketingEmployee)) 
            return Unauthorized("You don't have permission for this action");

        try
        { 
            await _loginService.CreateAccount(userDto, id);
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
    
    [HttpPut("{idAgency:int}/employees/{idUser:int}")]
    public async Task<IActionResult> UpdateUser(UserDto userDto, int idUser, int idAgency)
    {
        try
        {
            var token = Request.Headers.Authorization[0]![7..];
            var jwt = new JwtSecurityToken(token);
            
            if (int.TryParse(jwt.Claims.First(c => c.Type == "agencyId").Value, out var agencyId)
                && agencyId != idAgency)
            {
                return Unauthorized("You don't have permission for this action");
            }
        
        
            if (userDto.Role is not (Role.AgencyAdmin or Role.Agent or Role.MarketingEmployee)) 
                return Unauthorized("You don't have permission for this action");
            
            await _loginService.UpdateAgencyUserAccount(idUser, idAgency, userDto);
            
            return Ok();
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
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

    [HttpDelete("{idAgency:int}/employees/{idUser:int}")]
    public async Task<IActionResult> DeleteUser([FromRoute] int idAgency, [FromRoute] int idUser)
    {
        try
        {
            var token = Request.Headers.Authorization[0]![7..];
            var jwt = new JwtSecurityToken(token);
            
            if (int.TryParse(jwt.Claims.First(c => c.Type == "agencyId").Value, out var agencyId)
                && agencyId != idAgency)
            {
                return Unauthorized("You don't have permission for this action");
            }

            await _repositories.Users.Remove(idUser);
            
            await _repositories.Users.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpGet("{id:int}/employees")]
    public IActionResult GetUsers([FromRoute] int id, [FromQuery] PaginationDto filter)
    {
        IEnumerable<AgencyUser> items = _repositories.Users.FindAgencyUsers().Where(u => u.AgencyId == id);

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