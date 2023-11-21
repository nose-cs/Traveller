using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Exceptions;
using Traveller.Services;

namespace Traveller.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IdentityController : ControllerBase
{
    private readonly LoginService _loginService;
    private readonly ILogger<HotelController> _logger;

    public IdentityController(LoginService loginService, ILogger<HotelController> logger)
    {
        _loginService = loginService;
        _logger = logger;
    }

    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<ActionResult<TokenDto>> Login([FromBody] LoginRequestDto requestDto)
    {
        try
        {
            var token = await _loginService.Login(requestDto);
            return Ok(TokenDto.Map(token));
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
    
    [HttpPost("register")]
    [AllowAnonymous]
    public async Task<ActionResult<TokenDto>> Signup([FromBody] UserDto userDto)
    {
        try
        {
            if (userDto.Role is not Role.Tourist)
            {
                return Unauthorized("You don't have permission for this action");
            }
            
            var token = await _loginService.CreateAccount(userDto, 0);
            return Ok(TokenDto.Map(token));
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
}