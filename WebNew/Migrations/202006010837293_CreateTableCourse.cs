namespace WebNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LecturerId = c.String(maxLength: 128),
                        Place = c.String(),
                        Datetime = c.DateTime(nullable: false),
                        CategoryId_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.LecturerId)
                .Index(t => t.LecturerId)
                .Index(t => t.CategoryId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "CategoryId_Id", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "CategoryId_Id" });
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
