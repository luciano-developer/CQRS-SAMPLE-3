using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Ordering.Domain.Entities;

namespace Ordering.Infrastructure.Data
{
    public class OrderingContext: DbContext
    {
        // private static bool _created;

        public OrderingContext(DbContextOptions<OrderingContext> options) :base(options)
        {
            // if(_created) return;
            // Database.Migrate();
            // _created = true;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrderingContext).Assembly);
        }        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products  { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractItem> ContractItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments  { get; set; }
        public DbSet<PaymentItem> PaymentItems  { get; set; }
    }
}