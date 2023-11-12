namespace Traveller.Domain.Models;

public class AgencyUser : User
{
    public int AgencyId { get; set; }
    public virtual Agency Agency { get; set; } = null!;
}