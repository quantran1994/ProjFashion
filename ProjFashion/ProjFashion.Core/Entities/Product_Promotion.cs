using ProjFashion.Core.Common;
using ProjFashion.Core.Entities.Products;

namespace ProjFashion.Core.Entities
{
    public class Product_Promotion : BaseEntity
    {
        public long ProductId { get; set; }
        public long PromotionId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Promotion Promotion { get; set; }
    }
}
