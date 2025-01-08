using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjFashion.Core.Entities.Inventories;

namespace ProjFashion.Core.Entities.Products
{
    public class CategorySize:BaseEntity
    {
        public long CategoryId { get; set; }
        public string SizeName { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductVariant> ProductVariants { get; set; }

    }
}
