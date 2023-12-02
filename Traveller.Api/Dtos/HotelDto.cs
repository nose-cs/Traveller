using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class HotelDto
{
    public int? Id { get; set; }
    public string Name { get; set; } = null!;
    public PlaceDto Address { get; set; } = null!;
    public Category Category { get; set; }
    public FileDto Image { get; set; }

    public static Hotel Map(HotelDto hotelDto)
    {
        var hotel = new Hotel() { Name = hotelDto.Name, AddressId = hotelDto.Address.Id, Category = hotelDto.Category };
        if (hotelDto.Id is null)
        {
            return hotel;
        }

        hotel.Id = (int)hotelDto.Id;
        return hotel;
    }
    public static HotelDto Map(Hotel hotel, string imagePath, string imageName)
    {
        return new HotelDto() { Id = hotel.Id, Address = PlaceDto.Map(hotel.Address), 
            Name = hotel.Name, Category = hotel.Category, Image = new FileDto(){Id = hotel.ImageId, FilePath = imagePath, Name = imageName}};
    }
}