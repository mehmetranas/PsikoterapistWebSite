namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSlideTableAfterAddedImageTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Slides", "Image_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Slides", "Image_Id");
            AddForeignKey("dbo.Slides", "Image_Id", "dbo.Images", "Id", cascadeDelete: true);
            DropColumn("dbo.Slides", "Title");
            DropColumn("dbo.Slides", "Url");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Slides", "Url", c => c.String(nullable: false));
            AddColumn("dbo.Slides", "Title", c => c.String(nullable: false));
            DropForeignKey("dbo.Slides", "Image_Id", "dbo.Images");
            DropIndex("dbo.Slides", new[] { "Image_Id" });
            DropColumn("dbo.Slides", "Image_Id");
        }
    }
}
