using Restaurant.Core.DataAccess;
using Restaurant.Entities.Items;

namespace Restaurant.DataAcess.Abstract.Items
{
    public interface IItemDal:IEntityRepository<Item>
    {
    }
}
