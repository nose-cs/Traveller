using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public enum Role
{
    Tourist = 0,
    Agent = 1,
    MarketingEmployee = 2,
    AgencyAdmin = 3,
    TravellerAdmin = 4
}

public class User : IDbModel
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Password { get; set; }

    public Role Role { get; set; }

    public int Id { get; set; }
}