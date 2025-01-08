using ProjFashion.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Entities.Inventories
{
    public class InventoryProduct : BaseEntity
    {
        public long InventoryId { get; set; }
        public long ProductId { get; set; }
        public decimal InputPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public ICollection<InventoryProduct_Detail> Details { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual Product Product { get; set; }
    }
}
