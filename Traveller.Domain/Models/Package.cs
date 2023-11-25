using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public class Package : IProduct
{
    public string Name { get; set; } = null!;
    public int Duration { get; set; }
    public int Id { get; set; }
    
    public virtual ICollection<PackageFacility> Facilities { get; set; } = null!;
    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
    public int ImageId { get; set; }
    public Image Image { get; set; } = null!;
}