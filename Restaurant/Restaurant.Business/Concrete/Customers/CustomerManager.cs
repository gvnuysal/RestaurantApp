using Restaurant.Business.Abstract;
using Restaurant.Business.Contract.Customer;
using Restaurant.DataAcess.Abstract.Customers;
using Restaurant.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Business.Concrete.Customers
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public virtual async Task<Customer> Add(Customer customer)
        {
            return  await _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public virtual async Task<Customer> Get(Guid id)
        {
            return await _customerDal.Get(c => c.Id == id);
        }

        public virtual async Task<List<Customer>> GetList()
        {
            return await _customerDal.GetList();
        }

        public virtual async Task<Customer> Update(Customer customer)
        {
            return await _customerDal.Update(customer);
        }
    }
}
