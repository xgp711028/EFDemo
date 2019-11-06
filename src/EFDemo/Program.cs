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
            using (var efDbContext = new EfDbContext())
            {
                efDbContext.Blogs.Add(new Blog()
                {
                    Name = "Jeffcky",
                    Url = "http://www.cnblogs.com/CreateMyself"
                });
                efDbContext.SaveChanges();
            }
        }
    }
}