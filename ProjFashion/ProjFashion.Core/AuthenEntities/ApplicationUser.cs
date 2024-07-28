using Microsoft.AspNetCore.Identity;
using ProjFashion.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.AuthenEntities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public virtual List<Order> Orders { get; set; } = new List<Order>();
    }
}
