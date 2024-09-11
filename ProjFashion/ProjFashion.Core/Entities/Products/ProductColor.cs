using ProjFashion.Core.Common;

namespace ProjFashion.Core.Entities.Products
{
    public class ProductColor : BaseEntity
    {
        public string SKU { get; set; } = string.Empty;
        public long ProductId { get; set; }
        public string Colour { get; set; }
        public virtual Product? Product { get; set; }
        public virtual ICollection<ProductColorImage>? ProductColorImages { get; set; }
        public virtual ICollection<ProductColorSize>? ProductColorSizes { get; set; }
    }
}
