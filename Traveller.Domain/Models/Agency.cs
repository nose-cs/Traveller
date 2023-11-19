using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public class Agency : IDbModel
{
    public string Name { get; set; } = null!;
    public string Fax { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int AddressId { get; set; }
    public Place Address { get; set; } = null!;
    
    public virtual ICollection<TourOffer> Tours { get; set; } = new List<TourOffer>();
    public virtual ICollection<PackageOffer> Packages { get; set; } = new List<PackageOffer>();
    public virtual ICollection<HotelOffer> Hotels { get; set; } = new List<HotelOffer>();
    public virtual ICollection<FlightOffer> Flights { get; set; } = new List<FlightOffer>();

    public ICollection<AgencyUser> AgencyUsers = new List<AgencyUser>();
    public int Id { get; set; }
}