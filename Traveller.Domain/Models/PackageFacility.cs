namespace Traveller.Domain.Models;

public class PackageFacility : IDbModel
{
    public int PackageId { get; set; }
    public virtual Package Package { get; set; } = null!;
    public int FacilityId { get; set; }
    public virtual Facility Facility { get; set; } = null!;
    public double Price { get; set; }
    public int Id { get; set; }
}