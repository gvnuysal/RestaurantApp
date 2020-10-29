using Restaurant.Core.Entities;
using System;

namespace Restaurant.Entities.OrderItems
{
    public class OrderItem:IEntity
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }
    }
}
