using Microsoft.EntityFrameworkCore;
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
        return _context.Flights.Include(f => f.Source).Include(f => f.Destination).AsNoTracking();
    }

    public async ValueTask<Flight?> FindById(int key)
    {
        return await _context.Flights.AsNoTracking().Include(f => f.Source).Include(f => f.Destination)
            .FirstOrDefaultAsync(f => f.Id == key);
    }

    public string GetName(int key)
    {
        return _context.Flights.Where(flight => flight.Id == key).Select(flight => flight.Airline + ": " + flight.Source + " - " + flight.Destination).First();
    }
}