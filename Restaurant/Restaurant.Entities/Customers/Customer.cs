using Restaurant.Core.Entities;
using System;

namespace Restaurant.Entities.Customers
{
    public class Customer:IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
