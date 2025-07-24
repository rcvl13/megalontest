using Microsoft.EntityFrameworkCore;
using CustomerOrders.Data.Models;


namespace CustomerOrders.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
           
            var customerAliceId = Guid.Parse("481cf36a-fdb8-4911-853f-34ad26df4a2a");
            var customerBobId = Guid.Parse("1db7a052-91d5-43f0-8eeb-c852b504cd59");

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerID = customerAliceId,
                    FirstName = "Alice",
                    LastName = "Smith",
                    DOB = DateTime.Parse("1/1/1987")
                },
                new Customer
                {
                    CustomerID = customerBobId,
                    FirstName = "Bob",
                    LastName = "Smith",
                    DOB = DateTime.Parse("12/12/1986")
                }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderID = 1,
                    CustomerID = customerAliceId,
                    ItemName = "Nail Polish",
                    ItemPrice = 100.00m
                },
                new Order
                {
                    OrderID = 2,
                    CustomerID = customerAliceId,
                    ItemName = "Hair Brush",
                    ItemPrice = 500.00m
                },
                new Order
                {
                    OrderID = 3,
                    CustomerID = customerBobId,
                    ItemName = "Shaving Cream",
                    ItemPrice = 90.00m
                }
            );
        }
    }
}