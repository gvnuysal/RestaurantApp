using Restaurant.Entities.Items;
using Restaurant.Entities.Orders;

namespace Restaurant.Entities.OrderItems
{
    public class OrderItemNavigationProperties
    {
        public OrderItem OrderItem { get; set; }
        public Order Order { get; set; }
        public Item Item { get; set; }
    }
}
