using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo.Entity;

namespace EFDemo.Map
{
    public class BlogMap : EntityTypeConfiguration<Blog>
    {
        public BlogMap()
        {
            ToTable("Blog");
        }
    }
}