using Restaurant.Business.Contract.Customer;
using Restaurant.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Business.Abstract
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetList();
        Task<Customer> Get(Guid id);
        Task<Customer> Add(Customer customer);
        Task<Customer> Update(Customer customer);
        void Delete(Customer customer);
    }
}
