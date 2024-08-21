using ProjFashion.Core.Common;

namespace ProjFashion.Core.Entities
{
    public class ProductColor : BaseEntity
    {
        public string SKU { get; set; } = string.Empty;
        public long ProductId { get; set; }
        public double Size { get; set; }
        public virtual Product? Product { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetais { get; set; }
        public virtual ICollection<ProductColorImage>? ProductColorImages { get; set; }
        public virtual ICollection<Inventory>? Inventories { get; set; }
    }
}
