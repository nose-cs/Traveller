using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public class Payment : IDbModel
{
    public int Id { get; set; }
    public double Total { get; set; }

    public int UserId { get; set; }
    public User User { get; set; } = null!;
}

public class PaymentByCard : Payment
{
    public string CardNumber { get; set; } = null!;
}

public class PaymentByCash : Payment {}