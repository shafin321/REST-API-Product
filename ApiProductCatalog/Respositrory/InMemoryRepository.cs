using ApiProductCatalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProductCatalog.Respositrory
{
    public class InMemoryRepository
    {
        private readonly List<Item> items = new List<Item>()
        {
            new Item{Id=Guid.NewGuid(),Name="Silent Hill", Price=10, CreateDate=DateTimeOffset.UtcNow},
            new Item{Id=Guid.NewGuid(), Name="Potion", Price=8, CreateDate=DateTimeOffset.UtcNow},
             new Item{Id=Guid.NewGuid(), Name="IronSword", Price=9, CreateDate=DateTimeOffset.UtcNow}
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            //returning single item
           var item = items.Where(p => p.Id == id).FirstOrDefault();
            return item;   

        }
    }
}
