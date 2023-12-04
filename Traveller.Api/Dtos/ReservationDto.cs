using Traveller.Domain.Interfaces.Models;
using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class ReservationDto
{
    public int? Id { get; set; }
    public double? Price { get; set; }
    public DateTime DepartureDate { get; set; }
    public DateTime ArrivalDate { get; set; }
    public int NumberOfTravellers { get; set; }

    public int OfferId { get; set; }
    public int TouristId { get; set; }
    public string? CreditCardNumber { get; set; }

    public static void Map<TProduct, TReservation, TOffer>(TReservation reservation, ReservationDto reservationDto) where TProduct : class, IProduct, new()
                                                                                                                    where TReservation : class, IReservation<TProduct, TReservation, TOffer>, new()
                                                                                                                    where TOffer : class, IOffer<TProduct, TReservation, TOffer>, new()
    {
        reservation.ArrivalDate = reservationDto.ArrivalDate;
        reservation.DepartureDate = reservationDto.DepartureDate;
        reservation.NumberOfTravellers = reservationDto.NumberOfTravellers;
        reservation.OfferId = reservationDto.OfferId;
        reservation.TouristId = reservationDto.TouristId;
        if (reservationDto.Id != null)
            reservation.Id = (int)reservationDto.Id;
    }
    public static ReservationDto Map<TProduct, TReservation, TOffer>(TReservation reservation) where TProduct : class, IProduct, new()
                                                                                               where TReservation : class, IReservation<TProduct, TReservation, TOffer>, new()
                                                                                               where TOffer : class, IOffer<TProduct, TReservation, TOffer>, new()
    {
        return new ReservationDto
        {
            Id = reservation.Id,
            DepartureDate = reservation.DepartureDate,
            ArrivalDate = reservation.ArrivalDate,
            NumberOfTravellers = reservation.NumberOfTravellers,
            OfferId = reservation.OfferId,
            TouristId = reservation.TouristId,
            Price = reservation.Price
        };
    }
    
    //De cada Dto de Reservacion, podemos crear el pago a partir de los datos q nos da
    public Payment GetPayment(double price)
    {
        if (CreditCardNumber is null)
            return new PaymentByCash
            {
                Total = price,
                UserId = TouristId,
            };
        if (Confirm(CreditCardNumber, price))
            return new PaymentByCard
            {
                Total = price,
                UserId = TouristId,
                CardNumber = CreditCardNumber
            };
        throw new Exception("Payment Failed");
    }
    
    private static bool Confirm(string cardNumber, double price)
    {
        return true;
    }
}