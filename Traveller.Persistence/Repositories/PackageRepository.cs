using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class PackageRepository : IRepository<Package, int>
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
        return _context.Packages;
    }

    public async ValueTask<Package?> FindById(int key)
    {
        return await _context.Packages.FindAsync(key);
    }
    
    public async Task<IEnumerable<Tour>?>  FindTours(int key)
    {
        var package = await _context.Packages.AsNoTracking().Include(p => p.Tours).FirstOrDefaultAsync(p => p.Id == key);
        return package?.Tours;
    }
    
    public async Task<IEnumerable<Tour>?> FindFacilities(int key)
    {
        var package = await _context.Packages.AsNoTracking().Include(p => p.Tours).FirstOrDefaultAsync(p => p.Id == key);
        return package?.Tours;
    }
}