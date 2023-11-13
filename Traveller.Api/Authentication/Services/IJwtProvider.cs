using Traveller.Domain.Models;

namespace Traveller.Api.Authentication.Services;

public interface IJwtProvider
{
    string Generate(User user);
}