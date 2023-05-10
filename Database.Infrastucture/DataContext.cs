using Microsoft.EntityFrameworkCore;

namespace Database.Infrastucture;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}