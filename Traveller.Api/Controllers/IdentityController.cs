using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Traveller.Api.Authentication.Services;
using Traveller.Api.Dtos;
using Traveller.Domain.Models;
using Traveller.Dtos;

namespace Traveller.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IdentityController : ControllerBase
{
    private readonly LoginService _loginService;

    public IdentityController(LoginService loginService)
    {
        _loginService = loginService;
    }

    [HttpPost("login")]
    public async Task<ActionResult<TokenDto>> Login([FromBody] LoginRequest request)
    {
        try
        {
            var token = await _loginService.Login(request);
            return Ok(TokenDto.Map(token));
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }
    
    [HttpPost("signup")]
    public async Task<ActionResult<TokenDto>> Signup([FromBody] UserDto userDto)
    {
        //TODO: check valid email, add unique constraint to user email
        try
        {
            var token = await _loginService.CreateAccount(userDto, Role.Tourist, 0);
            return Ok(TokenDto.Map(token));
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpPost("signupAdmin")]
    [Authorize(Roles = ("Admin"))]
    public async Task<ActionResult> SignupAdmin([FromBody] UserDto userDto)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        //TODO: check valid email, add unique constraint to user email
        try
        {
            await _loginService.CreateAccount(userDto, Role.Admin, agencyId);
            return Ok();
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpPost("signupMarketingEmployee")]
    [Authorize(Roles = ("Admin"))]
    public async Task<ActionResult> SignupMarketingEmployee([FromBody] UserDto userDto)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        //TODO: check valid email, add unique constraint to user email
        try
        {
            await _loginService.CreateAccount(userDto, Role.MarketingEmployee, agencyId);
            return Ok();
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpPost("signupAgent")]
    [Authorize(Roles = ("Admin"))]
    public async Task<ActionResult> SignupAgent([FromBody] UserDto userDto)
    {
        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

        //TODO: check valid email, add unique constraint to user email
        try
        {
            await _loginService.CreateAccount(userDto, Role.Agent, agencyId);
            return Ok();
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }
}