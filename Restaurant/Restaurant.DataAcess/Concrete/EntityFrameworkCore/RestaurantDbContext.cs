using Microsoft.EntityFrameworkCore;
using Restaurant.Entities.Customers;
using Restaurant.Entities.Items;
using Restaurant.Entities.Orders;

namespace Restaurant.DataAcess.Concrete.EntityFrameworkCore
{
    public class RestaurantDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RestaurantDb;Integrated Security=true;");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item>  Items { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
