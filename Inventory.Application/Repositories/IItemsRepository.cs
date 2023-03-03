using Inventory.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Repositories
{
    public interface IItemsRepository
    {
        bool Create(Item item);
        Item GetById(int id);
        IEnumerable<Item> GetAll();
        bool Update(Item item);
        bool DeletebyId(int id);
    }
}
