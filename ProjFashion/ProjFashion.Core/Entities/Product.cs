using ProjFashion.Core.Common;
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
        public string Describe { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public long CategoryId { get; set; }
        public long BrandId { get; set; }
    }
}
