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
        var Offer = await FindById(key);
        if (Offer is not null)
        {
            _context.Remove(Offer);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<PackageOffer> Find()
    {
        return _context.PackageOffers;
    }

    public async ValueTask<PackageOffer?> FindById(int key)
    {
        return await _context.PackageOffers.FindAsync(key);
    }
}