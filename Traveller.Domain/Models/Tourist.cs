﻿namespace Traveller.Domain.Models;

public class Tourist : User
{
    public string Country { get; set; } = null!;
    
    public virtual ICollection<TourReservation> TourReservations { get; set; } = new List<TourReservation>();
    public virtual ICollection<HotelReservation> HotelReservations { get; set; } = new List<HotelReservation>();
    public virtual ICollection<FlightReservation> FlightReservations { get; set; } = new List<FlightReservation>();
    public virtual ICollection<PackageReservation> PackageReservations { get; set; } = new List<PackageReservation>();
}