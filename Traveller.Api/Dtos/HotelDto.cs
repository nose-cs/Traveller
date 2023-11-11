using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class HotelDto
{
    public int? Id { get; set; }
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public Category Category { get; set; }

    public static HotelDto Map(Hotel hotel)
    {
        return new HotelDto() { Id = hotel.Id, Address = hotel.Address, Name = hotel.Name, Category = hotel.Category};
    }
}