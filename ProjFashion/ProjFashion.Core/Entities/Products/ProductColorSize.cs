using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjFashion.Core.Entities.Inventories;

namespace ProjFashion.Core.Entities.Products
{
    public class ProductColorSize:BaseEntity
    {
        public double Size { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetais { get; set; }
        public virtual ICollection<Inventory>? Inventories { get; set; }
    }
}
