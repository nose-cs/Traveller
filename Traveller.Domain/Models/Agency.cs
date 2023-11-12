namespace Traveller.Domain.Models;

public class Agency : IDbModel
{
    public string Name { get; set; } = null!;
    public string Fax { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Address { get; set; } = null!;

    public ICollection<AgencyUser> AgencyUsers = new List<AgencyUser>();
    public int Id { get; set; }
}