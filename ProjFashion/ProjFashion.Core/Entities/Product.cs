using ProjFashion.Core.Common;
using ProjFashion.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public long CategoryId { get; set; }
        public long BrandId { get; set; }
        public EGenderFashion StyleFashion { get; set; }
        public bool IsBestSelling { get; set; }
        public double Star { get; set; }
        public virtual Brand? Brand { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<ProductColor>? ProductColors { get; set; }
    }
}
