namespace Traveller.Dtos;
using Traveller.Domain.Models;
public class HotelFilterDTO
{
    public int? ProductId { get; set; }
    public string? Address { get; set; } 
    public string? Name { get; set; } 
    public Category? Category { get; set; }
}

