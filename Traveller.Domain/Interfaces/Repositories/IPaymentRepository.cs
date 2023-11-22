using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IPaymentRepository : IRepository<Payment, int>
{
}