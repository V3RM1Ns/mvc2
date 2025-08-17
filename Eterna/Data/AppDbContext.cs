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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Portfolio - Category relationship
            modelBuilder.Entity<Portfolio>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Portfolios)
                .HasForeignKey(p => p.CategoryId);

            // Portfolio - PortfolioImg relationship
            modelBuilder.Entity<PortfolioImg>()
                .HasOne(pi => pi.Portfolio)
                .WithMany(p => p.PortfolioImgs)
                .HasForeignKey(pi => pi.PortfolioId);

            // Seed data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Web Design" },
                new Category { Id = 2, Name = "Mobile App" },
                new Category { Id = 3, Name = "Branding" }
            );

            modelBuilder.Entity<Slider>().HasData(
                new Slider 
                { 
                    Id = 1, 
                    Title = "Welcome to <span>Eterna</span>", 
                    Description = "We are team of talented designers making websites with Bootstrap", 
                    ImageUrl = "hero-carousel-1.webp", 
                    ButtonText = "Get Started", 
                    ButtonUrl = "#about" 
                },
                new Slider 
                { 
                    Id = 2, 
                    Title = "At vero eos et <span>accusamus</span>", 
                    Description = "Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus", 
                    ImageUrl = "hero-carousel-2.webp", 
                    ButtonText = "Get Started", 
                    ButtonUrl = "#about" 
                },
                new Slider 
                { 
                    Id = 3, 
                    Title = "Temporibus autem <span>quibusdam</span>", 
                    Description = "Beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit", 
                    ImageUrl = "hero-carousel-3.webp", 
                    ButtonText = "Get Started", 
                    ButtonUrl = "#about" 
                }
            );

            modelBuilder.Entity<Portfolio>().HasData(
                new Portfolio 
                { 
                    Id = 1, 
                    Title = "Modern Website Design", 
                    Description = "A modern and responsive website design for a tech company.", 
                    ImageUrl = "portfolio-1.webp", 
                    CategoryId = 1 
                },
                new Portfolio 
                { 
                    Id = 2, 
                    Title = "Mobile Banking App", 
                    Description = "A secure and user-friendly mobile banking application.", 
                    ImageUrl = "portfolio-2.webp", 
                    CategoryId = 2 
                },
                new Portfolio 
                { 
                    Id = 3, 
                    Title = "Brand Identity Design", 
                    Description = "Complete brand identity design for a startup company.", 
                    ImageUrl = "portfolio-3.webp", 
                    CategoryId = 3 
                }
            );

            modelBuilder.Entity<PortfolioImg>().HasData(
                new PortfolioImg { Id = 1, ImageUrl = "portfolio-1.webp", PortfolioId = 1 },
                new PortfolioImg { Id = 2, ImageUrl = "portfolio-4.webp", PortfolioId = 1 },
                new PortfolioImg { Id = 3, ImageUrl = "portfolio-7.webp", PortfolioId = 1 },
                new PortfolioImg { Id = 4, ImageUrl = "portfolio-2.webp", PortfolioId = 2 },
                new PortfolioImg { Id = 5, ImageUrl = "portfolio-5.webp", PortfolioId = 2 },
                new PortfolioImg { Id = 6, ImageUrl = "portfolio-3.webp", PortfolioId = 3 },
                new PortfolioImg { Id = 7, ImageUrl = "portfolio-6.webp", PortfolioId = 3 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
