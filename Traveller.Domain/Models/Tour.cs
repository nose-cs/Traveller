using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public enum Day
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

public class Tour : IProduct
{
    public int SourcePlaceId { get; set; }
    public Place SourcePlace { get; set; } = null!;
    public int DestinationPlaceId { get; set; }
    public Place DestinationPlace { get; set; } = null!;
    public Day SourceDay { get; set; }
    public uint Duration { get; set; }
    public TimeOnly SourceTime { get; set; }
    public TimeOnly DestinationTime { get; set; }

    public virtual ICollection<Package> Packages { get; set; } = new List<Package>();
    public int Id { get; set; }
    public int ImageId { get; set; }
    public Image Image { get; set; } = null!;
}

public class ExtendedTour : Tour
{
    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}