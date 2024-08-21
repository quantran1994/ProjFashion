using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Common
{
    public interface IEntity
    {
        long Id { get; set; }
        string CreatedBy { get; set; }
        DateTime Created { get; set; }
        string? LastModifiedBy { get; set; }
        DateTime? LastModified { get; set; }
    }
}