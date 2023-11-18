using Traveller.Domain.Interfaces.Models;
using Traveller.Domain.Models;

namespace Traveller.Domain.Models;

public enum Category
{
    oneStar = 1,
    twoStars = 2,
    threeStars = 3,
    fourStars = 4,
    fiveStars = 5
}

public class Hotel : IProduct
{
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public Category Category { get; set; }
    
    public int Id { get; set; }
}