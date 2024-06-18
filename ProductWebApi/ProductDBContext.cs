using Microsoft.EntityFrameworkCore;
using ProductWebApi.Models;

namespace ProductWebApi
{
    public class ProductDBContext : DbContext
    {
        //static readonly string connectionString = "Server=localhost; User ID=root; Password=pass; Database=blog";
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
