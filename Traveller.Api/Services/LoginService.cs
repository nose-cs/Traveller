using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;
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

    public async Task<string> ChangePassword(int userId, ChangePasswordRequestDto requestDto)
    {
        var dbUser = await _repository.FindById(userId);

        if (dbUser is null || !_passwordService.CheckPassword(requestDto.OldPassword, dbUser))
            throw new BadRequestException("Invalid credentials");

        dbUser.Password = _passwordService.EncryptPassword(requestDto.NewPassword);
        await _repository.SaveChangesAsync();

        var token = _jwtProvider.Generate(dbUser);
        return token;
    }

    public async Task UpdateAgencyUserAccount(int idUser, int agencyId, UserDto userDto)
    {
        var dbUser = await _repository.FindById(idUser);
        if (dbUser is AgencyUser agencyUser && agencyUser.AgencyId != agencyId || dbUser is null)
        {
            throw new NotFoundException($"User with id {idUser} doesn't exist in agency {agencyId}");
        }
            
        var user = await _repository.FindByEmail(userDto.Email);
        
        if (user is not null && user.Id != idUser)
        {
            throw new BadRequestException($"Email {userDto.Email} already exists");
        }
        
        if (userDto.Password is null)
        {
            throw new BadRequestException("Password can't be null");
        }
            
        dbUser.Email = userDto.Email;
        dbUser.Password = _passwordService.EncryptPassword(userDto.Password);
        dbUser.Role = userDto.Role;
        dbUser.Name = userDto.Name;
            
        await _repository.SaveChangesAsync();
    }
}