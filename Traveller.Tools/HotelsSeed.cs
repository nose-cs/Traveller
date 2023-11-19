using Traveller.Domain.Models;

namespace Traveller.Tools;

public partial class Program
{
    private static async Task AddHotelsAsync()
    {
        foreach (var hotel in GenerateHotels())
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
                Address = "123 Main Street, New York, NY",
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz Carlton",
                Address = "456 Broadway, Los Angeles, CA",
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Name = "The Plaza Hotel",
                Address = "789 Fifth Avenue, New York, NY",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Waldorf Astoria",
                Address = "321 Park Avenue, New York, NY",
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Name = "The Four Seasons",
                Address = "654 Broadway, New York, NY",
                Category = Category.TwoStars
            },
            new Hotel
            {
                Name = "The Beverly Wilshire",
                Address = "987 Wilshire Boulevard, Los Angeles, CA",
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Delaire",
                Address = "111 Del Mar Drive, Delaire, DE",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Cancun",
                Address = "222 Cancun Drive, Cancun, MX",
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Bangkok",
                Address = "333 Silom Road, Bangkok, TH",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, St. Thomas",
                Address = "444 St. Thomas Drive, St. Thomas, VI",
                Category = Category.OneStar
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Paris",
                Address = "555 Champs-Elysées, Paris, FR",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Rome",
                Address = "666 Via Veneto, Rome, IT",
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Geneva",
                Address = "777 Rue du Rhône, Geneva, CH",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, San Francisco",
                Address = "888 Union Square, San Francisco, CA",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Boston",
                Address = "999 Commonwealth Avenue, Boston, MA",
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, San Diego",
                Address = "1111 Horton Plaza, San Diego, CA",
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Chicago",
                Address = "2222 Michigan Avenue, Chicago, IL",
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Miami",
                Address = "3333 Collins Avenue, Miami, FL",
                Category = Category.OneStar
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Honolulu",
                Address = "4444 Kalakaua Avenue, Honolulu, HI",
                Category = Category.TwoStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Orlando",
                Address = "5555 International Drive, Orlando, FL",
                Category = Category.ThreeStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Las Vegas",
                Address = "6666 Las Vegas Boulevard South, Las Vegas, NV",
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, San Antonio",
                Address = "7777 Commerce Street, San Antonio, TX",
                Category = Category.FiveStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Dallas",
                Address = "8888 Market Center Drive, Dallas, TX",
                Category = Category.TwoStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Atlanta",
                Address = "9999 Peachtree Street, Atlanta, GA",
                Category = Category.FourStars
            },
            new Hotel
            {
                Name = "The Ritz-Carlton, Seattle",
                Address = "11111 University Street, Seattle, WA",
                Category = Category.ThreeStars
            }
        };
    }
}