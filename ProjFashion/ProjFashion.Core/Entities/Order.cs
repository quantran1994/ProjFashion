using ProjFashion.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Entities
{
    public class Order:BaseEntity
    {
        public long CustomerId { get; set; }
        public decimal Total { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; }= string.Empty;
        public long ProvinceId { get; set; }
        public long DistrictId { get; set; }
        public long WardId { get; set; }
        public string Address { get; set; } = string.Empty;
    }
}
