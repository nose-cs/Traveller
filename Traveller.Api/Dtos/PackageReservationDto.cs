using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class PackageReservationDto
{
    public int? Id { get; set; }
    public double? Price { get; set; }
    public DateTime DepartureDate { get; set; }
    public DateTime ArrivalDate { get; set; }
    public int NumberOfTravellers { get; set; }

    public int OfferId { get; set; }
    public int TouristId { get; set; }
    public string? CreditCardNumber { get; set; }
    public int[]? Facilities { get; set; }

    public static PackageReservation Map(PackageReservationDto reservationDto)
    {
        return new PackageReservation
        {
            ArrivalDate = reservationDto.ArrivalDate,
            DepartureDate = reservationDto.DepartureDate,
            NumberOfTravellers = reservationDto.NumberOfTravellers,
            OfferId = reservationDto.OfferId,
            TouristId = reservationDto.TouristId
        };
    }

    public static ReservationDto Map(PackageReservation reservation)
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