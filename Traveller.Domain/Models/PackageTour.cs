namespace Traveller.Domain.Models;

public class PackageTour
{
    public int PackageId { get; set; }
    public virtual Package Package { get; set; } = null!;
    public int TourId { get; set; }
    public virtual Tour Tour { get; set; } = null!;
}