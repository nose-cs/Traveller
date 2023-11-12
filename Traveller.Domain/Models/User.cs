namespace Traveller.Domain.Models;

public enum Role
{
    Tourist,
    Agent,
    MarketingEmployee,
    Admin
}

public class User : IDbModel
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Password { get; set; }

    public Role Role { get; set; }

    public int Id { get; set; }
}