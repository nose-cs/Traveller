using Traveller.Domain;

namespace Traveller.Persistence.Repositories;

public interface IRepository<TModel, in TKey> where TModel : IDbModel where TKey: IComparable
{
    Task AddAsync(TModel model);
    Task Remove(TKey key);
    Task SaveChangesAsync();

    IEnumerable<TModel> Find();
    ValueTask<TModel?> FindById(TKey key);
}