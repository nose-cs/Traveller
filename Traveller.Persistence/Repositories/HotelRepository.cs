﻿using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class HotelRepository : IRepository<Hotel, int>
{
    private readonly TravellerContext _context;

    public HotelRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Hotel model)
    {
        await _context.AddAsync(model);
    }

    public async Task Remove(int key)
    {
        var hotel = await FindById(key);
        if (hotel is not null)
        {
            _context.Remove(hotel);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<Hotel> Find()
    {
        return _context.Hotels;
    }

    public async ValueTask<Hotel?> FindById(int key)
    {
        return await _context.Hotels.FindAsync(key);
    }

    public string getName(int key)
    {
        return _context.Hotels.Where(hotel => hotel.Id == key).Select(hotel => hotel.Name).First();
    }
}