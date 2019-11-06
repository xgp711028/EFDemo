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
                var customer = new Customer
                {
                    Name = "张三",
                    Email = "741003989@qq.com",
                    CreatedTime = DateTime.Now,
                    ModifiedTime = DateTime.Now,
                    Orders = new List<Order>
                    {
                        new Order
                        {
                            Quanatity = 12,
                            Price = 1500,
                            CreatedTime = DateTime.Now,
                            ModifiedTime = DateTime.Now
                        },
                        new Order
                        {
                            Quanatity = 10,
                            Price = 2500,
                            CreatedTime = DateTime.Now,
                            ModifiedTime = DateTime.Now
                        }
                    }
                };
                efDbContext.Customers.Add(customer);
                efDbContext.SaveChanges();
            }
        }
    }
}