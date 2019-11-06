﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Entity
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}