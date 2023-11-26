using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class FileDto
{
    public int Id { get; set; }
    public byte[] FileData { get; set; } = null!;
}