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
        public long ProductId { get; set; }
        public decimal PrimeCost { get; set; }
        public decimal CostPrice { get; set; }
        public virtual Product Product { get; set; }
    }
}
