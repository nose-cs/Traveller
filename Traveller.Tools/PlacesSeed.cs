using Traveller.Domain.Models;

namespace Traveller.Tools;

public partial class Program
{
    private static IEnumerable<Place> _places = null!;
    private const int PlacesCount = 200;

    private static async Task AddPlacesAsync()
    {
        _places = GeneratePlaces();
        foreach (var place in _places)
        {
            await _appDbContext.AddAsync(place);
        }
    }

    private static IEnumerable<Place> GeneratePlaces()
    {
        var cities = GetCities();
        var addresses = GetAddresses();

        return Enumerable.Range(1, PlacesCount).Select(_ =>
        {
            var (country, city) = cities.ElementAt(Random.Next(0, cities.Length));
            return new Place
            {
                Country = country,
                City = city,
                Address = addresses[Random.Next(0, addresses.Length)]
            };
        });
    }

    private static (string, string)[] GetCities()
    {
        return new[]
        {
            ("England", " London"),
            ("New South Wales", " Australia"),
            ("Victoria", " Australia"),
            ("Île-de-France", " France"),
            ("Comunidad de Madrid", " Spain"),
            ("Lazio", " Italy"),
            ("New York", " USA"),
            ("California", " USA"),
            ("Delaware", " USA"),
            ("Texas", " USA"),
            ("Florida", " USA"),
            ("Ontario", " Canada"),
            ("Quebec", " Canada"),
            ("British Columbia", " Canada"),
            ("Alberta", " Canada"),
            ("Manitoba", " Canada"),
            ("Queensland", " Australia")
        };
    }

    private static string[] GetAddresses()
    {
        return new[]
        {
            "123 Main Street",
            "456 Broadway",
            "789 Fifth Avenue",
            "321 Park Avenue",
            "654 Broadway",
            "987 Wilshire Boulevard",
            "111 Del Mar Drive",
            "222 Drive", "333 Silom Road",
            "444 St. Thomas Drive",
            "666 Via Veneto", "777 Rue du Rhône",
            "999 Commonwealth Avenue", "7777 Commerce Street",
            "8888 Market Center Drive",
            "9999 Peachtree Street",
            "11111 University Street"
        };
    }
}