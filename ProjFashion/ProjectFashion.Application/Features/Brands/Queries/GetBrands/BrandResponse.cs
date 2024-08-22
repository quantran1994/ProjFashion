using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFashion.Application.Features.Brands.Queries.GetBrands
{
    public class BrandResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
    }
}
