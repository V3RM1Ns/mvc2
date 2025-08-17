using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Category> Categories { get; set; }
    
}
