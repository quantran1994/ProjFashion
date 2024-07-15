using ProjFashion.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Entities
{
    public class Inventory:BaseEntity
    {
        public long ProductColorId { get; set; }
        public int Quantity { get; set; }
        public decimal PrimeCost{ get; set; }
    }
}
