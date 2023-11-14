using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;
using Traveller.Dtos;

namespace Traveller.Services;

public class LoginService
{
    private readonly IUserRepository _repository;
    private readonly IJwtProvider _jwtProvider;
    private readonly IPasswordService _passwordService;
    private readonly ILogger<LoginService> _logger;

    public LoginService(IUserRepository repository, ILogger<LoginService> logger, IJwtProvider jwtProvider, IPasswordService passwordService)
    {
        _repository = repository;
        _logger = logger;
        _jwtProvider = jwtProvider;
        _passwordService = passwordService;
    }

    public async Task<string> Login(LoginRequestDto requestDto)
    {
        var user = await _repository.FindByEmail(requestDto.Email);
        
        if (user is null || !_passwordService.CheckPassword(requestDto.Password, user))
        {
            throw new Exception("not found: invalid credentials");
        }
        
        var token = _jwtProvider.Generate(user);
        return token;
    }

    public async Task<string> CreateAccount(UserDto userDto, Role role, int agencyId)
    {
        var user = await _repository.FindByEmail(userDto.Email);
        
        if (user is not null)
        {
            throw new Exception("bad request: email already exists");
        }

        user = role switch
        {
            Role.Tourist => new Tourist()
            {
                Name = userDto.Name,
                Email = userDto.Email,
                Password = _passwordService.EncryptPassword(userDto.Password),
                Nationality = userDto.Nationality
            },
            Role.MarketingEmployee => new AgencyUser() { Role = Domain.Models.Role.MarketingEmployee, Name = userDto.Name, Email = userDto.Email, Password = _passwordService.EncryptPassword(userDto.Password), AgencyId = agencyId },
            Role.Agent => new AgencyUser() { Role = Domain.Models.Role.Agent, Name = userDto.Name, Email = userDto.Email , Password = _passwordService.EncryptPassword(userDto.Password), AgencyId = agencyId },
            Role.Admin => new AgencyUser() { Role = Domain.Models.Role.Admin, Name = userDto.Name, Email = userDto.Email , Password = _passwordService.EncryptPassword(userDto.Password), AgencyId = agencyId },
            _ => throw new ArgumentOutOfRangeException(nameof(role), role, "Role doesn't exist")
        };

        try
        {
            await _repository.AddAsync(user);
            await _repository.SaveChangesAsync();
        }
        catch(Exception e)
        {
            _logger.LogError(e.Message);
            throw new Exception("An error has raised, user had not added");
        }

        var token = _jwtProvider.Generate(user);
        return token;
    }
}