using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Entity
{
    public class MemberContact
    {
        public long Id { get; set; }
        public string ContactNumber { get; set; }
        public virtual Member Member { get; set; }
    }
}