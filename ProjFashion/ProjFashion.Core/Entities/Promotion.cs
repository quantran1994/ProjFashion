using ProjFashion.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Entities
{
    public class Promotion:BaseEntity
    {
        public long ProductId { get; set; }
        public decimal SaleOff { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
