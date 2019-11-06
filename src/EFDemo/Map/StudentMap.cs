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
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            ToTable("Students");

            HasKey(a => a.Id);

            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Name).IsFixedLength().HasMaxLength(50);
            Property(a => a.Age);
            Property(a => a.CreatedTime);
            Property(a => a.ModifiedTime);

            HasMany(a => a.Courses).WithMany(a => a.Students)
                .Map(a => a.ToTable("StudentCourses")
                    .MapLeftKey("StudentId")
                    .MapRightKey("CourseId"));
        }
    }
}