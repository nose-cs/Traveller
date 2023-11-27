using Traveller.Domain.Interfaces.Models;
using Traveller.Domain.Models;

namespace Traveller.Domain.Models;

public enum Category
{
    OneStar = 1,
    TwoStars = 2,
    ThreeStars = 3,
    FourStars = 4,
    FiveStars = 5
}

public class Hotel : IProduct
{
    public string Name { get; set; } = null!;
    public int AddressId { get; set; }
    public Place Address { get; set; } = null!;
    public Category Category { get; set; }
    
    public int Id { get; set; }
    public int ImageId { get; set; }
    public Image Image { get; set; } = null!;
}