using Traveller.Domain.Interfaces.Models;
using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class PaymentDto
{
    public int Id { get; set; }
    public double Total { get; set; }
    public int UserId { get; set; }

    public static Payment Map(PaymentDto paymentDto)
    {
        Payment payment = new Payment();
        payment.Id = paymentDto.Id;
        payment.Total = paymentDto.Total;
        payment.UserId = paymentDto.UserId;
        return payment;
    }
    //Por ahora no necesito el mapeo inverso
}