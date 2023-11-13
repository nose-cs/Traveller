using Traveller.Domain.Models;

namespace Traveller.Services;

public interface IJwtProvider
{
    string Generate(User user);
}