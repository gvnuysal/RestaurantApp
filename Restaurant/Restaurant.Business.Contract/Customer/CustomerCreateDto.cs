using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Business.Contract.Customer
{
    public class CustomerCreateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
