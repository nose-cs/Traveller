using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public class Package : IOffer<PackageReservation, Package>
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public uint Duration { get; set; }
    public double Price { get; set; }
    public uint Capacity { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    
    public int AgencyId { get; set; }
    public virtual Agency Agency { get; set; } = null!;
    public int ImageId { get; set; }
    public Image Image { get; set; } = null!;
    
    public virtual ICollection<PackageFacility> Facilities { get; set; } = null!;
    public virtual ICollection<PackageTour> Tours { get; set; } = new List<PackageTour>();
    public virtual ICollection<PackageReservation> Reservations { get; set; } = new List<PackageReservation>();
}