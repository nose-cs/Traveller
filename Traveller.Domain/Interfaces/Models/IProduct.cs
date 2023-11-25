using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Models;

public interface IProduct : IDbModel
{
    int ImageId { get; set; }
    Image Image { get; set; }
}