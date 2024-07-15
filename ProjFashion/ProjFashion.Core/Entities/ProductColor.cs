using ProjFashion.Core.Common;

namespace ProjFashion.Core.Entities
{
    public class ProductColor : BaseEntity
    {
        public string SKU { get; set; } = string.Empty;
        public int ProductId { get; set; }
        public int Size { get; set; }
    }
}
