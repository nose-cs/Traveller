using Traveller.Domain.Interfaces.Repositories;
using Traveller.Dtos;
using Traveller.Exceptions;

namespace Traveller.Services;

public class LoginService
{
    private readonly IUserRepository _repository;
    private readonly IJwtProvider _jwtProvider;
    private readonly IPasswordService _passwordService;

    public LoginService(IUserRepository repository, IJwtProvider jwtProvider, IPasswordService passwordService)
    {
        _repository = repository;
        _jwtProvider = jwtProvider;
        _passwordService = passwordService;
    }

    public async Task<string> Login(LoginRequestDto requestDto)
    {
        var user = await _repository.FindByEmail(requestDto.Email);
        if (user is null || !_passwordService.CheckPassword(requestDto.Password, user))
        {
            throw new BadRequestException("Invalid credentials");
        }
        
        var token = _jwtProvider.Generate(user);
        return token;
    }

    public async Task<string> CreateAccount(UserDto userDto, int agencyId)
    {
        var user = await _repository.FindByEmail(userDto.Email);
        
        if (user is not null)
        {
            throw new BadRequestException($"Email {userDto.Email} already exists");
        }
        
        if (userDto.Password is null)
        {
            throw new BadRequestException("Password can't be null");
        }

        user = UserDto.Map(userDto, _passwordService.EncryptPassword(userDto.Password), agencyId);

        await _repository.AddAsync(user);
        await _repository.SaveChangesAsync();

        var token = _jwtProvider.Generate(user);
        return token;
    }
}