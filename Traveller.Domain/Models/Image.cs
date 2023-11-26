using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public class Image : IDbModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}