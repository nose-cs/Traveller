namespace Traveller.Domain.Models;

public class Package : IProduct
{
    public string Name { get; set; } = null!;
    public int Id { get; set; }
    
    public ICollection<PackageFacility> Facilities { get; set; } = null!;
    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
}