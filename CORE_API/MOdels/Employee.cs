﻿using System;
using System.Collections.Generic;

namespace CORE_API.MOdels
{
    public partial class Employee : EntityBase
    {
        public int EmpUniqueId { get; set; }
        public string EmpNo { get; set; } = null!;
        public string EmpName { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public int Salary { get; set; }
        public int? DeptUniqueId { get; set; }

        public virtual Department? DeptUnique { get; set; }
    }
}
