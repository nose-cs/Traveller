using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IHotelRepository : IRepository<Hotel, int>
{
    string GetName(int key);
}