using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Entity
{
    public class Member
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual MemberContact Contact { get; set; }
    }
}