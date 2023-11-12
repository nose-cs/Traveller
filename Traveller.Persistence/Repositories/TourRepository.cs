using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class TourRepository : IRepository<Tour, int>
{
    private readonly TravellerContext _context;

    public TourRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Tour model)
    {
        await _context.AddAsync(model);
    }

    public async Task Remove(int key)
    {
        var tour = await FindById(key);
        if (tour is not null)
        {
            _context.Remove(tour);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }


    public IEnumerable<Tour> Find()
    {
        return _context.Tours;
    }

    public async ValueTask<Tour?> FindById(int key)
    {
        return await _context.Tours.FindAsync(key);
    }

    public async Task<IEnumerable<Package>> FindPackages(int key)
    {
        var tour = await _context.Tours.AsNoTracking().Include(t => t.Packages).FirstOrDefaultAsync(t => t.Id == key);
        return tour?.Packages ?? new List<Package>();
    }
}