﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Common
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
