using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public class PackageReservation: IReservation<PackageReservation, Package>
{
    public int Id { get; set; }
    public double Price { get; set; }
    public DateTime DepartureDate { get; set; }
    public DateTime ArrivalDate { get; set; }
    public int NumberOfTravellers { get; set; }
    
    public int OfferId { get; set; }
    public virtual Package Offer { get; set; } = null!;
    public int TouristId { get; set; }
    public virtual Tourist Tourist { get; set; } = null!;
    public int PaymentId { get; set; }
    public virtual Payment Payment { get; set; } = null!;
    public int ArrivalFlightId { get; set; }
    public virtual FlightReservation ArrivalFlight { get; set; } = null!;
    public int DepartureFlightId { get; set; }
    public virtual FlightReservation DepartureFlight { get; set; } = null!;
}