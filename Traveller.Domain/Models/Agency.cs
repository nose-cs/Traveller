namespace Traveller.Domain.Models;

public class Agency : IDbModel
{
    public string Name { get; set; } = null!;
    public string Fax { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Address { get; set; } = null!;
    
    public virtual ICollection<TourOffer> Tours { get; set; } = new List<TourOffer>();
    public virtual ICollection<Package> Packages { get; set; } = new List<Package>();
    public virtual ICollection<HotelOffer> Hotels { get; set; } = new List<HotelOffer>();
    public virtual ICollection<FlightOffer> Flights { get; set; } = new List<FlightOffer>();

    public ICollection<AgencyUser> AgencyUsers = new List<AgencyUser>();
    public int Id { get; set; }
}