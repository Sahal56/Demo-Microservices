using CustomerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerWebApi
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions<CustomerDBContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
    }
}
