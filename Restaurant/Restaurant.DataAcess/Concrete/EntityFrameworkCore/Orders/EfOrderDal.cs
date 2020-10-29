using Restaurant.Core.DataAccess.EntityframeworkCore;
using Restaurant.DataAcess.Abstract.Orders;
using Restaurant.Entities.Orders;

namespace Restaurant.DataAcess.Concrete.EntityFrameworkCore.Orders
{
    public class EfOrderDal:EfCoreEntityRepositoryBase<Order,RestaurantDbContext>,IOrdersDal
    {
    }
}
