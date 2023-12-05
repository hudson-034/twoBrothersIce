using Microsoft.EntityFrameworkCore;
using TwoBrothersIce.src.Domain.Entities.Customers;
using TwoBrothersIce.src.src.Domain.Entities.Customers;

namespace TwoBrothersIce.src.Data
{
    public class AppDbContext : DbContext
    {
        public IConfiguration _config { get; set; }

        public AppDbContext(IConfiguration configuration)
        {
            _config = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<PaymentTerm> PaymentTerm { get; set; }
    }
}
