using Restaurant.Core.DataAccess;
using Restaurant.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.DataAcess.Abstract.Orders
{
    public interface IOrdersDal:IEntityRepository<Order>
    {
    }
}
