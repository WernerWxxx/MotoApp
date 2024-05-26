namespace MotoApp.Data;

using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;
using MotoApp.Repositories;

public class MotoAppDbContext : DbContext
{
    public DbSet<CountriesCurrencies> CountriesCurrencies => Set<CountriesCurrencies>();

    public DbSet<PreciousMetals> PreciousMetals => Set<PreciousMetals>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseInMemoryDatabase("StorageMotoAppDb");
    }
    
}