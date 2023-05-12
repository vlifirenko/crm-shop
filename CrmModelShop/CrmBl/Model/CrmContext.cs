using Microsoft.EntityFrameworkCore;

namespace CrmBl.Model
{
    class CrmContex : DbContext
    {
        public DbSet<Check> Checks { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Sell> Sells { get; set; } = null!;
        public DbSet<Seller> Sellers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CrmDb;Integrated Security=True;");
        }
    }
}