using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
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

            if (userDto.Password == null || userDto.Password == "")
                return BadRequest("Password cannot be empty");

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

    [HttpPost("changePassword")]
    [Authorize]
    public async Task<ActionResult<TokenDto>> ChangePassword(ChangePasswordRequestDto changePasswordDto)
    {
        if (changePasswordDto.NewPassword == null || changePasswordDto.NewPassword == "")
            return BadRequest("Password cannot be empty");

        var token = Request.Headers.Authorization[0]!.Substring(7);
        var jwt = new JwtSecurityToken(token);
        var userId = int.Parse(jwt.Claims.First(c => c.Type == "id").Value);

        try
        {
            var newtoken = await _loginService.ChangePassword(userId, changePasswordDto);
            return Ok(TokenDto.Map(newtoken));
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