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
        return Enumerable.Range(1, PlacesCount).Select(_ =>
        {
            var (country, city) = Cities[Random.Next(0, Cities.Length)];
            return new Place
            {
                Country = country,
                City = city,
                Address = Addresses[Random.Next(0, Addresses.Length)]
            };
        });
    }

    private static readonly (string, string)[] Cities =
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

    private static readonly string[] Addresses =
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