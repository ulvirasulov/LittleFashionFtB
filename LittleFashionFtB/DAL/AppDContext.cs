using LittleFashionFtB.Models;
using Microsoft.EntityFrameworkCore;

namespace LittleFashionFtB.DAL
{
    public class AppDContext
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions options) : base(options) { }

            public DbSet<Product> Products { get; set; }


        }
    }
}
