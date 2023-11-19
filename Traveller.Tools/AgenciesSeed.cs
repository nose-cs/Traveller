using Traveller.Domain.Models;

namespace Traveller.Tools;

public partial class Program
{
    private static async Task AddAgenciesAsync()
    {
        foreach (var agency in GenerateAgencies())
        {
            await _appDbContext.AddAsync(agency);
        }
    }

    private static IEnumerable<Agency> GenerateAgencies()
    {
        return new[]
        {
            new Agency
            {
                Name = "Sunshine Travel", Fax = "+1-800-123-4567", Email = "sunshine@travel.com",
                Address = "123 Main Street, New York, NY 10001"
            },
            new Agency
            {
                Name = "Dream Tours", Fax = "+1-888-987-6543", Email = "dream@tours.com",
                Address = "456 Park Avenue, Los Angeles, CA 90001"
            },
            new Agency
            {
                Name = "Paradise Holidays", Fax = "+1-877-765-4321", Email = "paradise@holidays.com",
                Address = "789 Broadway, Chicago, IL 60601"
            },
            new Agency
            {
                Name = "Explorer Adventures", Fax = "+1-866-543-2109", Email = "explorer@adventures.com",
                Address = "101 Market Street, San Francisco, CA 94101"
            },
            new Agency
            {
                Name = "Star Travel", Fax = "+1-855-321-0987", Email = "star@travel.com",
                Address = "202 Main Street, Boston, MA 02101"
            },
            new Agency
            {
                Name = "Wonder Tours", Fax = "+1-844-210-9876", Email = "wonder@tours.com",
                Address = "303 Park Avenue, Miami, FL 33101"
            },
            new Agency
            {
                Name = "Bliss Holidays", Fax = "+1-833-098-7654", Email = "bliss@holidays.com",
                Address = "404 Broadway, Seattle, WA 98101"
            },
            new Agency
            {
                Name = "Adventure Zone", Fax = "+1-822-765-4320", Email = "adventure@zone.com",
                Address = "505 Market Street, Denver, CO 80201"
            },
            new Agency
            {
                Name = "Sky Travel", Fax = "+1-811-432-1098", Email = "sky@travel.com",
                Address = "606 Main Street, Houston, TX 77001"
            },
            new Agency
            {
                Name = "Magic Tours", Fax = "+1-800-109-8765", Email = "magic@tours.com",
                Address = "707 Park Avenue, Atlanta, GA 30301"
            }
        };
    }
}