using ProjFashion.Core.Common;
using ProjFashion.Core.Entities.Inventories;
using ProjFashion.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Entities.Products
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsUse { get; set; }
        public long CategoryId { get; set; }
        public long BrandId { get; set; }
        public EGenderFashion StyleFashion { get; set; }
        public bool IsBestSelling { get; set; }
        public double Star { get; set; }
        public bool HasClassification { get; set; }
        public virtual Brand? Brand { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<ProductVariant>? ProductVariants { get; set; }
        public virtual ICollection<InventoryProduct>? InventoryProducts { get; set; }
    }
}
