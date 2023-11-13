using Traveller.Domain.Models;

namespace Traveller.Api.Authentication.Services;

public interface IPasswordService
{
    public string? EncryptPassword(string password);
    public bool CheckPassword(string password, User user);
}