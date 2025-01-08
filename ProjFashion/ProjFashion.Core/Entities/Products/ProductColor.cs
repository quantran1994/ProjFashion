using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Entities.Products
{
    [Index(nameof(ColorName),IsUnique =true)]
    public class ProductColor:BaseEntity
    {
        public string ColorName { get; set; }
        public virtual ICollection<ProductVariant> ProductVariants { get; set; }
    }
}
