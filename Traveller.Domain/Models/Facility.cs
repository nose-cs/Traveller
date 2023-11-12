using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public class Facility : IDbModel
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Id { get; set; }
    
    public virtual ICollection<PackageFacility> Packages { get; set; } = null!;
}