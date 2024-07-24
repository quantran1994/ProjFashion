using ProjFashion.Core.Common;

namespace ProjFashion.Core.Entities
{
    public class ProductColorImage : BaseEntity
    {
        public int ProductColorId { get; set; }
        public string? ImageUrl { get; set; }
    }
}
