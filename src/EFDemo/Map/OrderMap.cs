using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo.Entity;

namespace EFDemo.Map
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // 表名
            ToTable("Orders");

            // 主键
            HasKey(a => a.Id);

            // 属性
            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Quanatity);
            Property(a => a.Price);
            Property(a => a.CustomerId);
            Property(a => a.CreatedTime);
            Property(a => a.ModifiedTime);

            // 关系
            HasRequired(a => a.Customer).WithMany(a => a.Orders).HasForeignKey(a => a.CustomerId).WillCascadeOnDelete(false);
        }
    }
}