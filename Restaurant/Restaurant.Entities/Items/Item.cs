using Restaurant.Core.Entities;
using System;

namespace Restaurant.Entities.Items
{
    public class Item:IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
    }
}
