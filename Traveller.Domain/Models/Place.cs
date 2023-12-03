using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public class Place : IDbModel
{
    public string Address { get; set; } = null!;
    public string City { get; set; } = null!;
    public string Country { get; set; } = null!;
    public int Id { get; set; }
    
    public virtual ICollection<Tour> ToursWithDestination { get; set; } = new List<Tour>();
    public virtual ICollection<Tour> ToursWithSource { get; set; } = new List<Tour>();

    public string getFullAddress()
    {
        return (Address != null ? Address + " ": "") + (City != null ? City + " ": "") + (Country != null ? Country + " " : "");
    }
}