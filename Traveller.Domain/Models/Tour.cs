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
    public string ArrivalPlace { get; set; } = null!;
    public string DeparturePlace { get; set; } = null!;
    public Day ArrivalDay { get; set; }
    public ushort Duration { get; set; }
    public TimeOnly ArrivalTime { get; set; }
    public TimeOnly DepartureTime { get; set; }

    public virtual ICollection<Package> Packages { get; set; } = new List<Package>();
    public int Id { get; set; }
}

public class ExtendedTour : Tour
{
    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}