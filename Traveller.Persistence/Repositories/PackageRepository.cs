using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class PackageRepository : IPackageRepository
{
    private readonly TravellerContext _context;

    public PackageRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Package model)
    {
        await _context.AddAsync(model);
    }

    public async Task Remove(int key)
    {
        var package = await FindById(key);
        if (package is not null)
        {
            _context.Remove(package);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<Package> Find()
    {
        return _context.Packages.Include(x => x.Facilities);
    }

    public async ValueTask<Package?> FindById(int key)
    {
        return await _context.Packages.Include(x => x.Facilities).FirstOrDefaultAsync(p => p.Id == key);
    }

    public async Task<IEnumerable<Tour>?> FindTours(int key)
    {
        var package = await _context.Packages.AsNoTracking()
            .Include(p => p.Tours).ThenInclude(t => t.Image)
            .FirstOrDefaultAsync(p => p.Id == key);
        return package?.Tours;
    }

    public async Task<IEnumerable<Hotel>?> FindHotels(int key)
    {
        var tours = await FindTours(key);
        
        if (tours is null) return null;
        
        var toursId = tours.Select(x => x.Id).ToHashSet();
        
        var hotels = _context.Set<ExtendedTour>()
            .Include(x => x.Hotels)
            .Where(x => toursId.Contains(x.Id))
            .SelectMany(x => x.Hotels);

        return hotels;
    }

    public string GetName(int key)
    {
        return _context.Packages.Where(package => package.Id == key).Select(package => package.Name).First();
    }
}