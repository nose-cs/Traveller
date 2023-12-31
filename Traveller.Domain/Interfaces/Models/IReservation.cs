﻿using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Models;

public interface IReservation<TReservation, TOffer> : IDbModel
    where TReservation : class, IReservation<TReservation, TOffer>, new()
    where TOffer : class, IOffer<TReservation, TOffer>, new()
{
    double Price { get; set; }
    DateTime DepartureDate { get; set; }
    DateTime ArrivalDate { get; set; }
    int NumberOfTravellers { get; set; }

    int OfferId { get; set; }
    TOffer Offer { get; set; }
    int TouristId { get; set; }
    Tourist Tourist { get; set; }
    
    int PaymentId { get; set; }
    Payment Payment { get; set; }
}

public interface IReservation<TProduct, TReservation, TOffer> : IReservation<TReservation, TOffer>
    where TProduct : class, IProduct, new()
    where TReservation : class, IReservation<TProduct, TReservation, TOffer>, new()
    where TOffer : class, IOffer<TProduct, TReservation, TOffer>, new()
{
}