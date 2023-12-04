using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public class Tour : IProduct
{
    public int SourcePlaceId { get; set; }
    public Place SourcePlace { get; set; } = null!;
    public int DestinationPlaceId { get; set; }
    public Place DestinationPlace { get; set; } = null!;
    public DayOfWeek SourceDay { get; set; }
    public uint Duration { get; set; }
    public TimeOnly SourceTime { get; set; }
    public TimeOnly DestinationTime { get; set; }

    public virtual ICollection<PackageTour> Packages { get; set; } = new List<PackageTour>();
    public int Id { get; set; }
    public int ImageId { get; set; }
    public Image Image { get; set; } = null!;
}

public class ExtendedTour : Tour
{
    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}