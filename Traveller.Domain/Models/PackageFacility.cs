namespace Traveller.Domain.Models;

public class PackageFacility : IDbModel
{
    public int PackageId { get; set; }
    public Package Package { get; set; } = null!;
    public int FacilityId { get; set; }
    public Facility Facility { get; set; } = null!;
    public double Price { get; set; }
    public int Id { get; set; }
}