namespace MotoApp.Data;

using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;
using MotoApp.Repositories;

public class MotoAppDbContext : DbContext
{
    public DbSet<Employee> Employees => Set<Employee>();

    public DbSet<BusinessPartner> BusinessPartners => Set<BusinessPartner>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseInMemoryDatabase("StorageMotoAppDb");
    }
}