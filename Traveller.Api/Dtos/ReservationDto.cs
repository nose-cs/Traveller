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
    public string PaymentFormat { get; set; }
    public string? CreditCardNumber { get; set; }
    public int? PaymentId { get; set; }

    public static void Map<TProduct, TReservation, TOffer>(TReservation reservation, ReservationDto reservationDto) where TProduct : class, IProduct, new()
                                                                                                                    where TReservation : class, IReservation<TProduct, TReservation, TOffer>, new()
                                                                                                                    where TOffer : class, IOffer<TProduct, TReservation, TOffer>, new()
    {
        reservation.Price = reservationDto.Price;
        reservation.DepartureDate = reservationDto.DepartureDate;
        reservation.NumberOfTravellers = reservationDto.NumberOfTravellers;
        reservation.OfferId = reservationDto.OfferId;
        reservation.TouristId = reservationDto.TouristId;
        if (reservationDto.Id != null)
            reservation.Id = (int)reservationDto.Id;
        if (reservationDto.ArrivalDate != null)
            reservation.ArrivalDate = (DateTime)reservationDto.ArrivalDate;
    }

    //De cada Dto de Reservacion, podemos crear el pago a partir de los datos q nos da
    public Payment Get_Payment()
    {
        if (CreditCardNumber != null)
        {
            if (Confirm(CreditCardNumber, Price))
                return new PaymentByCard()
                {
                    Total = Price,
                    UserId = TouristId,
                    CardNumber = CreditCardNumber
                };
            throw new Exception("Payment Failed");
        }
        return new PaymentByCash()
        {
            Total = Price,
            UserId = TouristId
        };
        bool Confirm(string CardNumber, double Price)
        {
            return true;
        }
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
            PaymentId = reservation.PaymentId,
        };
    }
}