using Traveller.Domain.Models;

namespace Traveller.Tools;

public static partial class Program
{
    private const string ImagesPath = @"C:\Proyecto de IS\Front\Travel-Agency-Web\Travel-Agency-Web\src\assets\Images";

    private static readonly IEnumerable<Image> HotelsPhotos = GetPhotosNames().Select(name => new Image{Name = name});
    private static readonly string[] HotelOffersPhotos = GetPhotosNames();
    private static readonly string[] ToursPhotos = GetPhotosNames();
    private static readonly string[] ToursOffersPhotos = GetPhotosNames();
    private static readonly string[] FlightOfferPhotos = GetPhotosNames();

    private static async Task AddPhotosAsync()
    {
        await _appDbContext.AddRangeAsync(HotelsPhotos);
    }

    private static string[] GetPhotosNames() => Directory.GetFiles($"{ImagesPath}", "*.png").Select(x => x[(ImagesPath.Length + 5) ..]).ToArray();
}
