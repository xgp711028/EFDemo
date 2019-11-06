﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Entity
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public int MaximumStrength { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}