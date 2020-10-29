using System;

namespace Restaurant.Business.Contract.Customer
{
    public class CustomerUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
