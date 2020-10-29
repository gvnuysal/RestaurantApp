using Restaurant.Core.DataAccess;
using Restaurant.Entities.Customers;

namespace Restaurant.DataAcess.Abstract.Customers
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
