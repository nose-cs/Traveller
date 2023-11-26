using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly TravellerContext _context;

    public UserRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(User model)
    {
        await _context.AddAsync(model);
    }

    public async Task Remove(int key)
    {
        var user = await FindById(key);
        if (user is not null)
        {
            _context.Remove(user);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<User> Find()
    {
        return _context.Users;
    }

    public async ValueTask<User?> FindByEmail(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }

    public async ValueTask<User?> FindById(int key)
    {
        return await _context.Users.FindAsync(key);
    }

    public IEnumerable<User> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<User, TInclude>> include)
    {
        return _context.Users.Include(include);
    }
}