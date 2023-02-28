using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Application.Models;
namespace Inventory.Infrastructure.Context
{
    public class InventoryDbContext : DbContext
    {

        public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
         : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
    }
}
