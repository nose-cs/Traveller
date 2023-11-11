using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class HotelDto
{
    public int? Id { get; set; }
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public Category Category { get; set; }

    public static Hotel Map(HotelDto hotelDto)
    {
        var hotel = new Hotel() { Name = hotelDto.Name, Address = hotelDto.Address, Category = hotelDto.Category };
        if (hotelDto.Id is null)
        {
            return hotel;
        }

        hotel.Id = (int)hotelDto.Id;
        return hotel;
    }
    public static HotelDto Map(Hotel hotel)
    {
        return new HotelDto() { Id = hotel.Id, Address = hotel.Address, Name = hotel.Name, Category = hotel.Category};
    }
}