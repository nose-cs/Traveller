using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Traveller.Persistence;

namespace Traveller.Tools;

public static partial class Program
{
    private static TravellerContext _appDbContext = null!;

    public static async Task Main()
    {
        var services = new ServiceCollection();

        services.AddDbContext<TravellerContext>(options =>
            options.UseNpgsql("Server=localhost; Port=5432; Database=Traveller; Username=postgres; Password=1234"));

        var serviceProvider = services.BuildServiceProvider();
        _appDbContext = serviceProvider.GetService<TravellerContext>()!;

        await Seed();
    }

    private static async Task Seed()
    {
        await AddPhotosAsync();
        if (await _appDbContext.SaveChangesAsync() > 0)
            Console.WriteLine("Image's data successfully seeded!");
        
        await AddPlacesAsync();
        if (await _appDbContext.SaveChangesAsync() > 0)
            Console.WriteLine("Place's data successfully seeded!");

        await AddAgenciesAsync();
        await AddHotelsAsync();
        await AddFlightsAsync();
        if (await _appDbContext.SaveChangesAsync() > 0)
            Console.WriteLine("Data successfully seeded!");

        await AddToursAsync();
        if (await _appDbContext.SaveChangesAsync() > 0)
            Console.WriteLine("Tour's data successfully seeded!");

        await AddUsers();
        if (await _appDbContext.SaveChangesAsync() > 0)
            Console.WriteLine("User's data successfully seeded!");

        await AddHotelOffersAsync();
        await AddTourOffersAsync();
        await AddFlightOffersAsync();
        if (await _appDbContext.SaveChangesAsync() > 0)
            Console.WriteLine("Offer's data successfully seeded!");
    }
}
