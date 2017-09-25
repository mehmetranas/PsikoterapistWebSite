namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImagesProıpertyToTheServiceClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "Service_Id", c => c.Int());
            CreateIndex("dbo.Images", "Service_Id");
            AddForeignKey("dbo.Images", "Service_Id", "dbo.Services", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "Service_Id", "dbo.Services");
            DropIndex("dbo.Images", new[] { "Service_Id" });
            DropColumn("dbo.Images", "Service_Id");
        }
    }
}
