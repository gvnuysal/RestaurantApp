using Restaurant.Business.Abstract.Orders;
using Restaurant.DataAcess.Abstract.Orders;
using Restaurant.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business.Concrete.Orders
{
    public class OrderManager : IOrderService
    {
        private readonly IOrdersDal _orderDal;

        public OrderManager(IOrdersDal orderDal)
        {
            _orderDal = orderDal;
        }

        public virtual async Task<Order> Add(Order order)
        {
            return await _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }

        public virtual async Task<Order> Get(Guid id)
        {
            return await _orderDal.Get(x=>x.Id==id);
        }

        public virtual async Task<List<Order>> GetList()
        {
            return await _orderDal.GetList();
        }

        public virtual async Task<Order> Update(Order order)
        {
            return await _orderDal.Update(order);
        }
    }
}
