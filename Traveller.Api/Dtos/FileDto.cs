using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class FileDto
{
    public int Id { get; set; }
    public string FileName { get; set; } = null!;
    public Stream FileStream { get; set; } = null!;
    
    public static Image Map(string fileName, Stream fileStream)
    {
        return new Image
        {
            ImagePath = fileName
        };
    }
}