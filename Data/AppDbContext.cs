using Microsoft.EntityFrameworkCore;
using EFCoreCrudDemo.Models;

namespace EFCoreCrudDemo.Data;

/// <summary>
/// DbContext is the bridge between your application and the database.
/// </summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
}
