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
        var offer = await FindById(key);
        if (offer is not null)
        {
            _context.Remove(offer);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<Package> Find()
    {
        return _context.Packages
            .Include(x => x.Image)
            .Include(x => x.Agency);
    }

    public async ValueTask<Package?> FindById(int key)
    {
        return await _context.Packages.Include(x => x.Image)
            .Include(x => x.Agency)
            .FirstOrDefaultAsync(x => x.Id == key);
    }

    public IEnumerable<Package> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<Package, TInclude>> include)
    {
        return _context.Packages.Include(include);
    }

    public Task<IEnumerable<Tour>> FindTours(int key)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Hotel>> FindHotels(int key)
    {
        throw new NotImplementedException();
    }
}