using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Traveller.Persistence;

internal class TravellerContextFactory : IDesignTimeDbContextFactory<TravellerContext>
{
    private const string ConnectionString = "Server=localhost; Port=5432; Database=Traveller; Username=postgres; Password=81377610";
    
    public TravellerContext CreateDbContext(string[] args)
    {
        var dbContextBuilder = new DbContextOptionsBuilder<TravellerContext>();
        dbContextBuilder.UseNpgsql(ConnectionString);
        return new TravellerContext(dbContextBuilder.Options);
    }
}