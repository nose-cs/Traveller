using Traveller.Domain.Models;

namespace Traveller.Tools;

public partial class Program
{
    private static IEnumerable<Hotel> _hotels = null!;
    private const int HotelCount = 25;

    private static async Task AddHotelsAsync()
    {
        _hotels = GenerateHotels();
        foreach (var hotel in _hotels)
        {
            await _appDbContext.AddAsync(hotel);
        }
    }

    private static IEnumerable<Hotel> GenerateHotels()
    {
        return new[]
        {
            new Hotel
            {
                Name = "The Grand Hotel",
                AddressId = Random.Next(1, 200),
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz Carlton",
                AddressId = Random.Next(1, 200),
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Name = "The Plaza Hotel",
                AddressId = Random.Next(1, 200),
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Waldorf Astoria",
                AddressId = Random.Next(1, 200),
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Name = "The Four Seasons",
                AddressId = Random.Next(1, 200),
                Category = Category.TwoStars
            },
            new Hotel
            {
                Name = "The Beverly Wilshire",
                AddressId = Random.Next(1, 200),
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Delaire",
                AddressId = Random.Next(1, 200),
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Cancun",
                AddressId = Random.Next(1, 200),
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Bangkok",
                AddressId = Random.Next(1, 200),
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, St. Thomas",
                AddressId = Random.Next(1, 200),
                Category = Category.OneStar
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Paris",
                AddressId = Random.Next(1, 200),
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Rome",
                AddressId = Random.Next(1, 200),
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Geneva",
                AddressId = Random.Next(1, 200),
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, San Francisco",
                AddressId = Random.Next(1, 200),
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Boston",
                AddressId = Random.Next(1, 200),
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, San Diego",
                AddressId = Random.Next(1, 200),
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Chicago",
                AddressId = Random.Next(1, 200),
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Miami",
                AddressId = Random.Next(1, 200),
                Category = Category.OneStar
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Honolulu",
                AddressId = Random.Next(1, 200),
                Category = Category.TwoStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Orlando",
                AddressId = Random.Next(1, 200),
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Las Vegas",
                AddressId = Random.Next(1, 200),
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, San Antonio",
                AddressId = Random.Next(1, 200),
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Dallas",
                AddressId = Random.Next(1, 200),
                Category = Category.TwoStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Atlanta",
                AddressId = Random.Next(1, 200),
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Seattle",
                AddressId = Random.Next(1, 200),
                Category = Category.ThreeStars
            }
        };
    }
}