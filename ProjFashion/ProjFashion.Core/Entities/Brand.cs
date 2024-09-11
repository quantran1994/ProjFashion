using ProjFashion.Core.Common;
using ProjFashion.Core.Entities.Products;

namespace ProjFashion.Core.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Describe { get; set; } = string.Empty;
        public virtual ICollection<Product>? Products { get; set; }
    }
}
