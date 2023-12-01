using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class ImageRepository : IImageRepository
{
    private readonly TravellerContext _context;

    public ImageRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Image model)
    {
        await _context.AddAsync(model);
    }
    public async Task Remove(int key)
    {
        var image = await FindById(key);
        if (image is not null)
        {
            _context.Remove(image);
        }
    }
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    public IEnumerable<Image> Find()
    {
        return _context.Set<Image>();
    }

    public IEnumerable<Image> FindWithInclude<TInclude>(Expression<Func<Image, TInclude>> include)
    {
        return _context.Set<Image>().Include(include);
    }

    public async ValueTask<Image?> FindById(int key)
    {
        return await _context.Set<Image>().FindAsync(key);
    }
}