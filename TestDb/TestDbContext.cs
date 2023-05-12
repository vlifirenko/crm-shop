using CrmBl.Test;
using Microsoft.EntityFrameworkCore;

namespace CrmBl.TestDb
{
    public class TestDbContext : DbContext
    {
        public DbSet<TestCustomer> Customers { get; set; } = null!;
        public DbSet<TestOrder> Orders { get; set; } = null!;
        public DbSet<TestProduct> Product { get; set; } = null!;
        public DbSet<TestOrderDetail> OrderDetail { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDb;Integrated Security=True;");
        }
    }
}
