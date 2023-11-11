namespace Traveller.Domain.Models;

public enum Category
{
}

public class Hotel : IProduct
{
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public Category Category { get; set; }
    
    public int Id { get; set; }
}