namespace MotoApp.Data;

using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;
using MotoApp.Repositories;

public class MotoAppDbContext : DbContext
{
    public DbSet<WalutyPanstw> WalutyPanstw => Set<WalutyPanstw>();

    public DbSet<MetaleSzlachetne> MetaleSzlachetne => Set<MetaleSzlachetne>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseInMemoryDatabase("StorageMotoAppDb");
    }
    
}