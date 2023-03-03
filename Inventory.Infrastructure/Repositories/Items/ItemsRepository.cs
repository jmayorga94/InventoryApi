using Inventory.Application.Models;
using Inventory.Application.Repositories;
using Inventory.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.Repositories.Items
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly InventoryDbContext _iventoryDbContext;
        public ItemsRepository(InventoryDbContext iventoryDbContext)
        {
            _iventoryDbContext = iventoryDbContext;
        }
        public bool Create(Item item)
        {
            var status = true;
            try
            {
                _iventoryDbContext.Items.Add(item);
                _iventoryDbContext.SaveChanges();
            }
            catch (Exception)
            {
                status = false;
                throw;
            }

            return status;
           

        }

        public bool DeletebyId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAll()
        {
            return _iventoryDbContext.Items.ToList();
        }

        public Item GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
