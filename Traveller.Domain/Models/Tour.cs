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
    public Day DepartureDay { get; set; }
    public TimeOnly ArrivalTime { get; set; }
    public TimeOnly DepartureTime { get; set; }
    public int Id { get; set; }
}

public class ExtendedTour : Tour
{
    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}