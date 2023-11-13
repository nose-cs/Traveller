namespace Traveller.Domain.Models;

public class PackageFacility
{
    public int PackageId { get; set; }
    public virtual Package Package { get; set; } = null!;
    public int FacilityId { get; set; }
    public virtual Facility Facility { get; set; } = null!;
    public double Price { get; set; }
}