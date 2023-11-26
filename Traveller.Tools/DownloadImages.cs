using System.Text.Json;
using HtmlAgilityPack;

namespace Traveller.Tools;

public static partial class Program
{
    public static async Task AddImagesAsync(string requestUri, string pathToSave, int imagesCount)
    {
        var imageList = await GetAllImages("hotel", "your-api-key", "your-cse-id");

        using var client = new HttpClient();
        for (var i = 0; i < Math.Min(imagesCount, imageList.Count); i++)
        {
            var imagePath = $"{pathToSave}{i}.jpg";
            var imageBytes = await client.GetByteArrayAsync(imageList[i]);
            await File.WriteAllBytesAsync(imagePath, imageBytes);
            await _appDbContext.AddAsync(imagePath);
        }
    }

    private static async Task<List<string?>> GetAllImages(string query, string apiKey, string cseId)
    {
        using var client = new HttpClient();
        var url = $"https://www.googleapis.com/customsearch/v1?key={apiKey}&cx={cseId}&q={query}&searchType=image";

        var jsonResponse = await client.GetStringAsync(url);
        var jsonDocument = JsonDocument.Parse(jsonResponse);

        return jsonDocument.RootElement.GetProperty("items").EnumerateArray().Select(item => item.GetProperty("link").GetString()).ToList();
    }
}