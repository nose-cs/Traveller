using Traveller.Domain.Interfaces.Models;

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
    public string Address { get; set; } = null!;
    public Category Category { get; set; }

    public int Id { get; set; }
}