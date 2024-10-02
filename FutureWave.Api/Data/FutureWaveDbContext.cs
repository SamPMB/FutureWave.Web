using FutureWave.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace FutureWave.Api.Data
{
    public class FutureWaveDbContext:DbContext
    {
        public FutureWaveDbContext(DbContextOptions<FutureWaveDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
