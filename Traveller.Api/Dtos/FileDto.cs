using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class FileDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string FilePath { get; set; } = null!;
    
    public static FileDto Map(Image file, string filePath)
    {
        return new FileDto
        {
            Id = file.Id,
            Name = file.Name, 
            FilePath = filePath
        };
    }
}
