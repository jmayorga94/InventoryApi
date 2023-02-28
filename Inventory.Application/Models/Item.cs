using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Models
{
    public class Item : FullAuditableModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public bool IsOnSale { get; set; }
        public string Notes { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? SoldDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? CurrentOrFinalPrice { get; set; }
    }
}
