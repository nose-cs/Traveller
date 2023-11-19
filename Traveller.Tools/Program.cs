using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Traveller.Persistence;

namespace Traveller.Tools;

public partial class Program
{
    private static TravellerContext _appDbContext = null!;

    public static async Task Main()
    {
        var services = new ServiceCollection();

        services.AddDbContext<TravellerContext>(options =>
            options.UseNpgsql("Server=localhost; Port=5432; Database=Traveller; Username=postgres; Password=root"));

        var serviceProvider = services.BuildServiceProvider();
        _appDbContext = serviceProvider.GetService<TravellerContext>()!;

        await AddPlacesAsync();
        if (await _appDbContext.SaveChangesAsync() > 0)
            Console.WriteLine("Place's data successfully seeded!");
        
        await AddAgenciesAsync();
        await AddHotelsAsync();
        if (await _appDbContext.SaveChangesAsync() > 0)
            Console.WriteLine("Data successfully seeded!");

        await AddHotelOffersAsync();

        if (await _appDbContext.SaveChangesAsync() > 0)
            Console.WriteLine("Offer's data successfully seeded!");
    }
}