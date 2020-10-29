using Restaurant.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Entities.Orders
{
    public class Order:IEntity
    {
        public Guid Id { get; set; }
        public string OrderNo { get; set; }
        public Guid CustomerId { get; set; }
        public string PMethod { get; set; }
        public decimal GTotal { get; set; }
    }
}
