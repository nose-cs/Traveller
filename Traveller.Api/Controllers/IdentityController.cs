using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Services;

namespace Traveller.Controllers;

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
    public async Task<ActionResult<TokenDto>> Login([FromBody] LoginRequestDto requestDto)
    {
        try
        {
            var token = await _loginService.Login(requestDto);
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
        var token = Request.Headers.Authorization[0]![7..];
        var jwt = new JwtSecurityToken(token);
        var agencyId = int.Parse(jwt.Claims.First(c => c.Type == "agencyId").Value);

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