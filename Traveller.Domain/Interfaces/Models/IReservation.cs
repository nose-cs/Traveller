using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Models;

public interface IReservation<TProduct, TReservation, TOffer> : IDbModel
    where TProduct : class, IProduct, new()
    where TReservation : class, IReservation<TProduct, TReservation, TOffer>, new()
    where TOffer : class, IOffer<TProduct, TReservation, TOffer>, new()
{
    double Price { get; set; }
    DateTime DepartureDate { get; set; }
    DateTime ArrivalDate { get; set; }
    int NumberOfTravellers { get; set; }

    int OfferId { get; set; }
    TOffer Offer { get; set; }
    int TouristId { get; set; }
    Tourist Tourist { get; set; }
}