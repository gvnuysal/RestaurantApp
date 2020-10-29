using Restaurant.Core.DataAccess;
using Restaurant.Entities.OrderItems;

namespace Restaurant.DataAcess.Abstract.OrderItems
{
    public interface IOrderItemDal:IEntityRepository<OrderItem>
    {
    }
}
