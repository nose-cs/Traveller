using Traveller.Domain.Interfaces.Models;
using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class ReservationDto
{
    public int? Id { get; set; }
    public double Price { get; set; }
    public DateTime DepartureDate { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public int NumberOfTravellers { get; set; }

    public int OfferId { get; set; }
    public int TouristId { get; set; }
    public int PaymentId { get; set; }
    public PaymentDto? paymentDto { get; set; }

    public static void Map<TProduct, TReservation, TOffer>(TReservation reservation, ReservationDto reservationDto) where TProduct : class, IProduct, new()
                                                                                                                    where TReservation : class, IReservation<TProduct, TReservation, TOffer>, new()
                                                                                                                    where TOffer : class, IOffer<TProduct, TReservation, TOffer>, new()
    {
        reservation.Price = reservationDto.Price;
        reservation.DepartureDate = reservationDto.DepartureDate;
        reservation.NumberOfTravellers = reservationDto.NumberOfTravellers;
        reservation.OfferId = reservationDto.OfferId;
        reservation.TouristId = reservationDto.TouristId;
        reservation.PaymentId = reservationDto.PaymentId;
        if (reservationDto.Id != null)
            reservation.Id = (int)reservationDto.Id;
        if (reservationDto.ArrivalDate != null)
            reservation.ArrivalDate = (DateTime)reservationDto.ArrivalDate;
    }
    public static ReservationDto Map<TProduct, TReservation, TOffer>(TReservation reservation) where TProduct : class, IProduct, new()
                                                                                               where TReservation : class, IReservation<TProduct, TReservation, TOffer>, new()
                                                                                               where TOffer : class, IOffer<TProduct, TReservation, TOffer>, new()
    {
        return new ReservationDto()
        {
            Id = reservation.Id,
            Price = reservation.Price,
            DepartureDate = reservation.DepartureDate,
            ArrivalDate = reservation.ArrivalDate,
            NumberOfTravellers = reservation.NumberOfTravellers,
            OfferId = reservation.OfferId,
            TouristId = reservation.TouristId,
            PaymentId = reservation.PaymentId
        };
    }
}