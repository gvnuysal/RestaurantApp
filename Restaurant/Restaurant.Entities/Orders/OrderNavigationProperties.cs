using Restaurant.Entities.Customers;

namespace Restaurant.Entities.Orders
{
    public class OrderNavigationProperties
    {
        public Order Order { get; set; }
        public Customer Customer { get; set; }
    }
}
