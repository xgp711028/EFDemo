using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo.Entity;

namespace EFDemo.Map
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // 表名
            ToTable("Customer");

            // 主键
            HasKey(a => a.Id);

            // 属性
            Property(a => a.Name).HasMaxLength(50).IsFixedLength().IsRequired();
            Property(a => a.Email).IsFixedLength().HasMaxLength(50).IsRequired();
            Property(a => a.CreatedTime);
            Property(a => a.ModifiedTime);

            // 关系
        }
    }
}