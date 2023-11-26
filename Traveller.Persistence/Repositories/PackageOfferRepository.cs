using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class PackageOfferRepository : IPackageOfferRepository
{
    private readonly TravellerContext _context;

    public PackageOfferRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(PackageOffer model)
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

    public IEnumerable<PackageOffer> Find()
    {
        return _context.PackageOffers.Include(x => x.Image);
    }

    public async ValueTask<PackageOffer?> FindById(int key)
    {
        return await _context.PackageOffers.Include(x => x.Image)
            .FirstOrDefaultAsync(x => x.Id == key);
    }

    public IEnumerable<PackageOffer> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<PackageOffer, TInclude>> include)
    {
        return _context.PackageOffers.Include(include);
    }
}