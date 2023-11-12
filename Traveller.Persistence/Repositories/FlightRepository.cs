using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class FlightRepository : IFlightRepository
{
    private readonly TravellerContext _context;

    public FlightRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Flight model)
    {
        await _context.AddAsync(model);
    }

    public async Task Remove(int key)
    {
        var flight = await FindById(key);
        if (flight is not null)
        {
            _context.Remove(flight);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<Flight> Find()
    {
        return _context.Flights;
    }

    public async ValueTask<Flight?> FindById(int key)
    {
        return await _context.Flights.FindAsync(key);
    }
}