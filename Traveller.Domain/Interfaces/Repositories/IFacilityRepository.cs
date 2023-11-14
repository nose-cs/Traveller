using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IFacilityRepository : IRepository<Facility, int>
{
    Task AddRangeAsync(IEnumerable<Facility> model);
    IEnumerable<Facility> FindById(HashSet<int> keys);
}