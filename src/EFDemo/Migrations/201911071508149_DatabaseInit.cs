namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseInit : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Blog", newName: "Blogs");
            DropForeignKey("dbo.StudentCourses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.MemberContacts", "MemberId", "dbo.Members");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.MemberContacts", new[] { "MemberId" });
            DropIndex("dbo.StudentCourses", new[] { "StudentId" });
            DropIndex("dbo.StudentCourses", new[] { "CourseId" });
            DropTable("dbo.Courses");
            DropTable("dbo.Students");
            DropTable("dbo.Customer");
            DropTable("dbo.Orders");
            DropTable("dbo.MemberContacts");
            DropTable("dbo.Members");
            DropTable("dbo.StudentCourses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentId, t.CourseId });
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MemberContacts",
                c => new
                    {
                        MemberId = c.Long(nullable: false),
                        ContactNumber = c.String(),
                    })
                .PrimaryKey(t => t.MemberId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quanatity = c.Byte(nullable: false),
                        Price = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, fixedLength: true),
                        Email = c.String(nullable: false, maxLength: 50, fixedLength: true),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, fixedLength: true),
                        Age = c.Byte(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, fixedLength: true),
                        MaximumStrength = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        ModifiedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.StudentCourses", "CourseId");
            CreateIndex("dbo.StudentCourses", "StudentId");
            CreateIndex("dbo.MemberContacts", "MemberId");
            CreateIndex("dbo.Orders", "CustomerId");
            AddForeignKey("dbo.MemberContacts", "MemberId", "dbo.Members", "Id");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customer", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentCourses", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Blogs", newName: "Blog");
        }
    }
}
