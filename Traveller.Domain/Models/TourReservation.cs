namespace Traveller.Domain.Models;

public class TourReservation : IReservation<Tour, TourReservation, TourOffer>
{
    public int Id { get; set; }
    public double Price { get; set; }
    public DateTime ArrivalDate { get; set; }
    public DateTime DepartureDate { get; set; }
    public int NumberOfTravellers { get; set; }
    
    public int OfferId { get; set; }
    public virtual TourOffer Offer { get; set; } = null!;
    public int TouristId { get; set; }
    public virtual Tourist Tourist { get; set; } = null!;
}