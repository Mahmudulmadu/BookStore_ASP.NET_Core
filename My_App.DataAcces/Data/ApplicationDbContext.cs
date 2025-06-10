using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using My_App.Models;
using My_App.Models.Models;

namespace My_App.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1, Name="Action", DisplayOrder= 1},
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2},
                new Category { Id = 3, Name = "History", DisplayOrder =3 }

                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Matrix",
                    Description = "Sci-fi action movie with virtual reality themes.",
                    ISBN = "ISBN0001",
                    Author = "Lana Wachowski",
                    ListPrice = 40,
                    Price = 35,
                    Price50 = 30,
                    Price100 = 25,
                    CategoryId = 1,
                    ImageUrl = "https://example.com/sapiens.jpg"
                },
                new Product
                {
                    Id = 2,
                    Title = "Interstellar",
                    Description = "A science fiction exploration of space and time.",
                    ISBN = "ISBN0002",
                    Author = "Christopher Nolan",
                    ListPrice = 45,
                    Price = 40,
                    Price50 = 36,
                    Price100 = 32,
                    CategoryId = 1,
                    ImageUrl = "https://example.com/sapiens.jpg"
                },
                new Product
                {
                    Id = 3,
                    Title = "The Art of War",
                    Description = "Ancient Chinese military treatise.",
                    ISBN = "ISBN0003",
                    Author = "Sun Tzu",
                    ListPrice = 30,
                    Price = 28,
                    Price50 = 25,
                    Price100 = 22,
                    CategoryId = 1,
                    ImageUrl = "https://example.com/sapiens.jpg"
                },
                new Product
                {
                    Id = 4,
                    Title = "1984",
                    Description = "Dystopian novel set in a totalitarian future.",
                    ISBN = "ISBN0004",
                    Author = "George Orwell",
                    ListPrice = 38,
                    Price = 34,
                    Price50 = 30,
                    Price100 = 27,
                    CategoryId = 2,
                    ImageUrl = "https://example.com/sapiens.jpg"
                },
                new Product
                {
                    Id = 5,
                    Title = "Brave New World",
                    Description = "A futuristic society with engineered citizens.",
                    ISBN = "ISBN0005",
                    Author = "Aldous Huxley",
                    ListPrice = 42,
                    Price = 37,
                    Price50 = 33,
                    Price100 = 29,
                    CategoryId = 2,
                    ImageUrl = "https://example.com/sapiens.jpg"
                },
                new Product
                {
                    Id = 6,
                    Title = "Sapiens",
                    Description = "A brief history of humankind.",
                    ISBN = "ISBN0006",
                    Author = "Yuval Noah Harari",
                    ListPrice = 50,
                    Price = 45,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 3,
                    ImageUrl = "https://example.com/sapiens.jpg"
                }
            );

        }
    }
}
