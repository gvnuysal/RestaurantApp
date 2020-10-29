using Restaurant.Core.DataAccess.EntityframeworkCore;
using Restaurant.DataAcess.Abstract.Customers;
using Restaurant.Entities.Customers;

namespace Restaurant.DataAcess.Concrete.EntityFrameworkCore.Customers
{
    public class EfCustomerDal:EfCoreEntityRepositoryBase<Customer,RestaurantDbContext>,ICustomerDal
    {

    }
}
