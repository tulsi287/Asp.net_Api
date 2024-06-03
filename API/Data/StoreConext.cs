using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreConext : DbContext
    {
        public StoreConext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}