using Restaurant.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business.Abstract.Orders
{
    public interface IOrderService
    {
        Task<Order> Get(Guid id);
        Task<List<Order>> GetList();
        Task<Order> Add(Order order);
        Task<Order> Update(Order order);
        void Delete(Order order);
    }
}
