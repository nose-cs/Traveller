using Traveller.Domain;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public interface IRepository<TModel, in TKey> where TModel : IDbModel where TKey: IComparable
{
    Task AddAsync(TModel model);
    Task Remove(TKey key);
    Task SaveChangesAsync();

    IEnumerable<Hotel> Find();
    ValueTask<TModel?> FindById(TKey key);
}