using ProjFashion.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Entities.Inventories
{
    public class InventoryDetail:BaseEntity
    {
        public long InventoryId { get; set; }
        public long ProductColorId { get; set; }
        public long ProductColorSizeId { get; set; }
        public int QuantityInStock { get; set; }
        public virtual ProductColor ProductColor { get; set; }
        public virtual ProductColorSize ProductColorSize { get; set; }
    }
}
