using Microsoft.AspNetCore.Mvc;
using Traveller.Api.Authentication.Services;
using Traveller.Api.Dtos;

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
    public async Task<ActionResult<string>> Login([FromBody] LoginRequest request)
    {
        try
        {
            var token = await _loginService.Login(request);
            return Ok(token);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }
    
    [HttpPost("signup")]
    public async Task<ActionResult<string>> Signup([FromBody] UserDto userDto)
    {
        //TODO: check valid email, add unique constraint to user email
        try
        {
            var token = await _loginService.CreateAccount(userDto, Role.Tourist);
            return Ok(token);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }
}