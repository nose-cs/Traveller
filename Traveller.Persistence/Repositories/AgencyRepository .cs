﻿using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class AgencyRepository : IAgencyRepository
{
    private readonly TravellerContext _context;

    public AgencyRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Agency model)
    {
        await _context.AddAsync(model);
    }

    public async Task Remove(int key)
    {
        var agency = await FindById(key);
        if (agency is not null)
        {
            _context.Remove(agency);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<Agency> Find()
    {
        return _context.Agencies.Include(x => x.Address);
    }

    public async ValueTask<Agency?> FindById(int key)
    {
        return await _context.Agencies.Include(x => x.Address).FirstOrDefaultAsync(x => x.Id == key);
    }

    public string GetName(int key)
    {
        return _context.Agencies.Where(agency => agency.Id == key).Select(agency => agency.Name).First();
    }

    public IEnumerable<Agency> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<Agency, TInclude>> include)
    {
        return _context.Agencies.Include(include);
    }
}