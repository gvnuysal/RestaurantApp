using Microsoft.AspNetCore.Mvc;
using Restaurant.Business.Abstract;
using Restaurant.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.WEBAPI.Controllers.Customers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase,ICustomerService
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public virtual async Task<Customer> Add(Customer customer)
        {
            return await _customerService.Add(customer);
        }

        [HttpDelete]
        public void Delete(Customer customer)
        {
            _customerService.Delete(customer);
        }

        [HttpGet("{id}")]
        public virtual async Task<Customer> Get(Guid id)
        {
            return await _customerService.Get(id);
        }

        [HttpGet]
        public Task<List<Customer>> GetList()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public Task<Customer> Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
