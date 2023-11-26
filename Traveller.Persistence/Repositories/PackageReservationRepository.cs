using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class PackageReservationRepository : IPackageReservationRepository
{
    private readonly TravellerContext _context;
    public PackageReservationRepository(TravellerContext context)
    {
        _context = context;
    }
    public async Task AddAsync(PackageReservation model)
    {
        await _context.AddAsync(model);
    }
    public async Task Remove(int key)
    {
        var packageReservation = await FindById(key);
        if (packageReservation is not null)
        {
            _context.Remove(packageReservation);
        }
    }
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    public IEnumerable<PackageReservation> Find()
    {
        return _context.PackageReservations;
    }
    public async ValueTask<PackageReservation?> FindById(int key)
    {
        return await _context.PackageReservations.FindAsync(key);
    }

    public IEnumerable<PackageReservation> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<PackageReservation, TInclude>> include)
    {
        return _context.PackageReservations.Include(include);
    }
}