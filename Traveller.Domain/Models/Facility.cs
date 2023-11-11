namespace Traveller.Domain.Models;

public class Facility : IDbModel
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Id { get; set; }
    
    public ICollection<PackageFacility> Packages { get; set; } = null!;
}