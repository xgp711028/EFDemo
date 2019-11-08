namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberAndContactTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberContacts",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ContactNumber = c.String(),
                        Student_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberContacts", "Student_Id", "dbo.Members");
            DropIndex("dbo.MemberContacts", new[] { "Student_Id" });
            DropTable("dbo.Members");
            DropTable("dbo.MemberContacts");
        }
    }
}
