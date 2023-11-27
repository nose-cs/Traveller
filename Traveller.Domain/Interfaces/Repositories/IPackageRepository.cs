using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IPackageRepository : IRepository<Package, int>
{
    Task<IEnumerable<Tour>?> FindTours(int key);
    Task<IEnumerable<Hotel>?> FindHotels(int key);
    string GetName(int key);
}