using Eterna.Migrations;
using Microsoft.EntityFrameworkCore;
using Eterna.Models;

namespace Eterna.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioImg> PortfolioImgs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}


