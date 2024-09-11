using ProjFashion.Core.Common;
using ProjFashion.Core.Entities.Products;
using ProjFashion.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Entities
{
    public class OrderDetail:BaseEntity
    {
        public long OrderId { get; set; }
        public long ProductColorId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public EPaymentType PaymentType { get; set; }
        public virtual ProductColor ProductColor { get; set; }
        public virtual Order Order { get; set; }
    }
}
