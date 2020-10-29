using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Business.Abstract.Orders;
using Restaurant.Entities.Orders;

namespace Restaurant.WEBAPI.Controllers.Orders
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase, IOrderService
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<Order> Add(Order order)
        {
            return await _orderService.Add(order);
        }

        [HttpDelete]
        public void Delete(Order order)
        {
            _orderService.Delete(order);
        }

        [HttpGet("{id}")]
        public virtual async Task<Order> Get(Guid id)
        {
            return await _orderService.Get(id);
        }
        [HttpGet]
        public virtual async Task<List<Order>> GetList()
        {
            return await _orderService.GetList();
        }
        [HttpPut]
        public Task<Order> Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
