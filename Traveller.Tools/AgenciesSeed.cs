using Traveller.Domain.Models;

namespace Traveller.Tools;

public static partial class Program
{
    private static IEnumerable<Agency> _agencies = null!;
    private const int AgenciesCount = 10;

    private static async Task AddAgenciesAsync()
    {
        _agencies = GenerateAgencies();
        await _appDbContext.AddRangeAsync(_agencies);
    }

    private static IEnumerable<Agency> GenerateAgencies()
    {
        return new[]
        {
            new Agency
            {
                Name = "Sunshine Travel", Fax = "+1-800-123-4567", Email = "sunshine@travel.com",
                AddressId = Random.Next(1, PlacesCount),
            },
            new Agency
            {
                Name = "Dream Tours", Fax = "+1-888-987-6543", Email = "dream@tours.com",
                AddressId = Random.Next(1, PlacesCount),
            },
            new Agency
            {
                Name = "Paradise Holidays", Fax = "+1-877-765-4321", Email = "paradise@holidays.com",
                AddressId = Random.Next(1, PlacesCount),
            },
            new Agency
            {
                Name = "Explorer Adventures", Fax = "+1-866-543-2109", Email = "explorer@adventures.com",
                AddressId = Random.Next(1, PlacesCount),
            },
            new Agency
            {
                Name = "Star Travel", Fax = "+1-855-321-0987", Email = "star@travel.com",
                AddressId = Random.Next(1, PlacesCount),
            },
            new Agency
            {
                Name = "Wonder Tours", Fax = "+1-844-210-9876", Email = "wonder@tours.com",
                AddressId = Random.Next(1, PlacesCount),
            },
            new Agency
            {
                Name = "Bliss Holidays", Fax = "+1-833-098-7654", Email = "bliss@holidays.com",
                AddressId = Random.Next(1, PlacesCount),
            },
            new Agency
            {
                Name = "Adventure Zone", Fax = "+1-822-765-4320", Email = "adventure@zone.com",
                AddressId = Random.Next(1, PlacesCount),
            },
            new Agency
            {
                Name = "Sky Travel", Fax = "+1-811-432-1098", Email = "sky@travel.com",
                AddressId = Random.Next(1, PlacesCount),
            },
            new Agency
            {
                Name = "Magic Tours", Fax = "+1-800-109-8765", Email = "magic@tours.com",
                AddressId = Random.Next(1, PlacesCount),
            }
        };
    }
}