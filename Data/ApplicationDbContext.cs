using Microsoft.EntityFrameworkCore;
using SampleApi.Models; // Import the Product class from SampleApi.Models

namespace SampleApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } // This references the Product class
        // Add other DbSets for other entities as needed
    }
}
