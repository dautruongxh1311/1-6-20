namespace WebNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToApplicationUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "CategoryId_Id", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "CategoryId_Id" });
            RenameColumn(table: "dbo.Courses", name: "CategoryId_Id", newName: "CategoryId");
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "CategoryId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Courses", "CategoryId");
            AddForeignKey("dbo.Courses", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            AlterColumn("dbo.Courses", "CategoryId", c => c.Byte());
            AlterColumn("dbo.Categories", "Name", c => c.String());
            DropColumn("dbo.AspNetUsers", "Name");
            RenameColumn(table: "dbo.Courses", name: "CategoryId", newName: "CategoryId_Id");
            CreateIndex("dbo.Courses", "CategoryId_Id");
            AddForeignKey("dbo.Courses", "CategoryId_Id", "dbo.Categories", "Id");
        }
    }
}
