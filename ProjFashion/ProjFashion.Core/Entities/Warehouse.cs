using ProjFashion.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Entities
{
    public class Warehouse:BaseEntity
    {
        public long ProductId { get; set; }
        public long Stock { get; set; }
        public decimal PrimeCost{ get; set; }
    }
}
