using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class TourReservationRepository : ITourReservationRepository
{
    private readonly TravellerContext _context;
    public TourReservationRepository(TravellerContext context)
    {
        _context = context;
    }
    public async Task AddAsync(TourReservation model)
    {
        await _context.AddAsync(model);
    }
    public async Task Remove(int key)
    {
        var tourReservation = await FindById(key);
        if (tourReservation is not null)
        {
            _context.Remove(tourReservation);
        }
    }
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    public IEnumerable<TourReservation> Find()
    {
        return _context.TourReservations;
    }
    public async ValueTask<TourReservation?> FindById(int key)
    {
        return await _context.TourReservations.FindAsync(key);
    }

    public IEnumerable<TourReservation> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<TourReservation, TInclude>> include)
    {
        return _context.TourReservations.Include(include);
    }
}