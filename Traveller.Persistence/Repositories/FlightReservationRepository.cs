using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class FlightReservationRepository : IFlightReservationRepository
{
    private readonly TravellerContext _context;
    public FlightReservationRepository(TravellerContext context)
    {
        _context = context;
    }
    public async Task AddAsync(FlightReservation model)
    {
        await _context.AddAsync(model);
    }
    public async Task Remove(int key)
    {
        var flightReservation = await FindById(key);
        if (flightReservation is not null)
        {
            _context.Remove(flightReservation);
        }
    }
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    public IEnumerable<FlightReservation> Find()
    {
        return _context.FlightReservations;
    }
    public async ValueTask<FlightReservation?> FindById(int key)
    {
        return await _context.FlightReservations.FindAsync(key);
    }

    public IEnumerable<FlightReservation> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<FlightReservation, TInclude>> include)
    {
        return _context.FlightReservations.Include(include);
    }
}