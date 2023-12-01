using Traveller.Domain.Models;

namespace Traveller.Tools;

public static partial class Program
{
    private static IEnumerable<Hotel> _hotels = null!;
    private const int HotelCount = 25;

    private static async Task AddHotelsAsync()
    {
        _hotels = GenerateHotels();
        await _appDbContext.AddRangeAsync(_hotels);
    }

    private static readonly List<string> HotelNames = new()
    {
        "The Grand Hotel", "The Ritz Carlton", "The Plaza Hotel", "The Waldorf Astoria", "The Four Seasons",
        "The Beverly Wilshire", "The Ritz-Carlton", "The Peninsula", "The Savoy", "The Mandarin Oriental",
        "The Dorchester", "The Langham", "The Connaught", "The Berkeley", "The Lanesborough", "The Shangri-La",
    };

    private static IEnumerable<Hotel> GenerateHotels()
    {
        return Enumerable.Range(1, HotelCount).Select(i => new Hotel
        {
            Name = HotelNames[i % HotelNames.Count],
            AddressId = Random.Next(1, PlacesCount),
            Category = (Category)Random.Next(1, 5),
            ImageId = 1
        });
    }
}