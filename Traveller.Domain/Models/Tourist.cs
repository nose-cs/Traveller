namespace Traveller.Domain.Models;

public class Tourist : User
{
    public string Nationality { get; set; } = null!;
    
    public virtual ICollection<TourReservation> TourReservations { get; set; } = new List<TourReservation>();
    public virtual ICollection<HotelReservation> HotelReservations { get; set; } = new List<HotelReservation>();
    public virtual ICollection<FlightReservation> FlightReservations { get; set; } = new List<FlightReservation>();
}