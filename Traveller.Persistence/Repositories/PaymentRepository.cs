using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class PaymentRepository : IPaymentRepository
{
    private readonly TravellerContext _context;

    public PaymentRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Payment model)
    {
        await _context.AddAsync(model);
    }

    public async Task Remove(int key)
    {
        var payment = await FindById(key);
        if (payment is not null)
        {
            _context.Remove(payment);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<Payment> Find()
    {
        return _context.Payment;
    }

    public async ValueTask<Payment?> FindById(int key)
    {
        return await _context.Payment.FindAsync(key);
    }
}