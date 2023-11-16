using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IPackageRepository : IRepository<Package, int>
{
    Task<IEnumerable<Tour>?> FindTours(int key);
    Task<IEnumerable<Tour>?> FindFacilities(int key);
    string GetName(int key);
}