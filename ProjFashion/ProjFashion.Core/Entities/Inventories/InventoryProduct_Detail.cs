using Microsoft.EntityFrameworkCore;
using ProjFashion.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Entities.Inventories
{
    public class InventoryProduct_Detail : BaseEntity
    {
        public long InventoryProductId { get; set; }
        public long ProductVariantId { get; set; }
        public int Quantity { get; set; }
        public virtual ProductVariant ProductVariant { get; set; }
        public virtual InventoryProduct InventoryProduct { get; set; }
    }
}
