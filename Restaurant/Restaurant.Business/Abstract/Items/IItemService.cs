using Restaurant.Entities.Items;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Business.Abstract.Items
{
    public interface IItemService
    {
        Task<List<Item>> GetAll();
        Task<Item> Get(Guid id);
        Task<Item> Add(Item item);
        Task<Item> Update(Item item);
        void Delete(Item item);
        
    }
}
