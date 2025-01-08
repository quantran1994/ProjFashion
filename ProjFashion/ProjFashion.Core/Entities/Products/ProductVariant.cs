using Microsoft.EntityFrameworkCore;
using ProjFashion.Core.Common;

namespace ProjFashion.Core.Entities.Products
{
    public class ProductVariant : BaseEntity
    {
        public string SKU { get; set; } = string.Empty;
        public long ProductId { get; set; }
        public string? ProductColourId { get; set; }
        public string? CategorySizeId { get; set; }
        public virtual Product? Product { get; set; }
        public virtual ProductColor? ProductColor { get; set; }
        public virtual CategorySize? CategorySize { get; set; }
        public virtual ICollection<ProductVariantImage>? ProductVariantImages { get; set; }
    }
}
