using Traveller.Domain.Models;

namespace Traveller.Dtos;
public class HotelFilterDTO
{
    public int? ProductId { get; set; }
    public string? Address { get; set; } 
    public string? Name { get; set; } 
    public Category? Category { get; set; }
}

