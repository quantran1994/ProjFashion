using ProjFashion.Core.Common;

namespace ProjFashion.Core.Entities.Products
{
    public class ProductColorImage : BaseEntity
    {
        public long ProductColorId { get; set; }
        public string? ImageUrl { get; set; }
        public virtual ProductColor? ProductColor { get; set; }
    }
}
