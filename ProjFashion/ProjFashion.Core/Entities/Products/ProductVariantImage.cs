using ProjFashion.Core.Common;

namespace ProjFashion.Core.Entities.Products
{
    public class ProductVariantImage : BaseEntity
    {
        public long ProductVariantId { get; set; }
        public string? ImageUrl { get; set; }
        public virtual ProductVariant? ProductVariant { get; set; }
    }
}
