using ProjFashion.Core.Common;
using ProjFashion.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Entities.Inventories
{
    public class Inventory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<InventoryProduct> InventoryProducts { get; set; }
    }
}
