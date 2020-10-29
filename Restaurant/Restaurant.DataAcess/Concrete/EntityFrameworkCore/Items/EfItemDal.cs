using Restaurant.Core.DataAccess.EntityframeworkCore;
using Restaurant.DataAcess.Abstract.Items;
using Restaurant.Entities.Items;

namespace Restaurant.DataAcess.Concrete.EntityFrameworkCore.Items
{
    public class EfItemDal:EfCoreEntityRepositoryBase<Item,RestaurantDbContext>,IItemDal
    {
    }
}
