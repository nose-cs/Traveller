using Traveller.Domain.Interfaces.Models;
using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IRepository<TModel, in TKey> where TModel : IDbModel where TKey: IComparable
{
    Task AddAsync(TModel model);
    Task Remove(TKey key);
    Task SaveChangesAsync();
    IEnumerable<TModel> Find();
    IEnumerable<TModel> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<TModel, TInclude>> include);
    ValueTask<TModel?> FindById(TKey key);
}