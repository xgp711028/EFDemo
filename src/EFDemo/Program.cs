using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo.Entity;

namespace EFDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using (var efDbContext = new EfDbContext())
            //{
            //    efDbContext.Blogs.Add(new Blog()
            //    {
            //        Name = "Jeffcky",
            //        Url = "http://www.cnblogs.com/CreateMyself"
            //    });
            //    efDbContext.SaveChanges();
            //}

            using (var efDbContext = new EfDbContext())
            {
                //var customer1 = new Customer
                //{
                //    Name = "张三",
                //    Email = "741003989@qq.com",
                //    CreatedTime = DateTime.Now,
                //    ModifiedTime = DateTime.Now,
                //    Orders = new List<Order>
                //    {
                //        new Order
                //        {
                //            Quanatity = 12,
                //            Price = 1500,
                //            CreatedTime = DateTime.Now,
                //            ModifiedTime = DateTime.Now
                //        },
                //        new Order
                //        {
                //            Quanatity = 10,
                //            Price = 2500,
                //            CreatedTime = DateTime.Now,
                //            ModifiedTime = DateTime.Now
                //        }
                //    }
                //};
                //efDbContext.Customers.Add(customer1);
                //efDbContext.SaveChanges();

                //var customer = efDbContext.Customers.FirstOrDefault(a => a.Id == 1);
                //if (customer != null)
                //{
                //    efDbContext.Customers.Remove(customer);
                //}
                //efDbContext.SaveChanges();

                //var student = new Student
                //{
                //    Name = "张三",
                //    Age = 26,
                //    CreatedTime = DateTime.Now,
                //    ModifiedTime = DateTime.Now,
                //    Courses = new List<Course>
                //    {
                //        new Course
                //        {
                //            Name = "C#",
                //            MaximumStrength = 12,
                //            CreatedTime = DateTime.Now,
                //            ModifiedTime = DateTime.Now
                //        },
                //        new Course
                //        {
                //            Name = "Entity Framework 6.x",
                //            MaximumStrength = 12,
                //            CreatedTime = DateTime.Now,
                //            ModifiedTime = DateTime.Now
                //        }
                //    }
                //};
                //var course = new Course
                //{
                //    Name = "Web Api",
                //    MaximumStrength = 12,
                //    CreatedTime = DateTime.Now,
                //    ModifiedTime = DateTime.Now,
                //    Students = new List<Student>
                //    {
                //        new Student()
                //        {
                //            Name = "李四",
                //            Age = 25,
                //            CreatedTime = DateTime.Now,
                //            ModifiedTime = DateTime.Now
                //        },
                //        new Student()
                //        {
                //            Name = "王五",
                //            Age = 26,
                //            CreatedTime = DateTime.Now,
                //            ModifiedTime = DateTime.Now
                //        }
                //    }
                //};
                //efDbContext.Students.Add(student);
                //efDbContext.Courses.Add(course);
                //efDbContext.SaveChanges();

                //var member = new Member()
                //{
                //    Name = "张三"
                //};
                //var member2 = new Member()
                //{
                //    Name = "李四",
                //    Contact = new MemberContact()
                //    {
                //        ContactNumber = "13755053757",
                //    }
                //};
                //var member3 = new Member()
                //{
                //    Name = "王五",
                //    Contact = new MemberContact()
                //    {
                //        ContactNumber = "13755050241",
                //    }
                //};
                //efDbContext.Members.Add(member);
                //efDbContext.Members.Add(member2);
                //efDbContext.Members.Add(member3);
            }
        }
    }
}