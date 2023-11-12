using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class FacilityRepository : IFacilityRepository
{
    private readonly TravellerContext _context;

    public FacilityRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Facility model)
    {
        await _context.AddAsync(model);
    }

    public async Task AddRangeAsync(IEnumerable<Facility> model)
    {
       await _context.AddRangeAsync(model);
    }

    public async Task Remove(int key)
    {
        var facility = await FindById(key);
        if (facility is not null)
        {
            _context.Remove(facility);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<Facility> Find()
    {
        return _context.Facilities;
    }

    public IEnumerable<Facility> FindById(HashSet<int> keys)
    {
        return _context.Facilities.Where(f => keys.Contains(f.Id));
    }
    public async ValueTask<Facility?> FindById(int key)
    {
        return await _context.Facilities.FindAsync(key);
    }
}