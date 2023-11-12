namespace Traveller.Domain.Models;

public class Tourist : User
{
    public string Nationality { get; set; } = null!;
}