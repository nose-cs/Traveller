using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IAgencyRepository : IRepository<Agency, int>
{
    string GetName(int key);
}