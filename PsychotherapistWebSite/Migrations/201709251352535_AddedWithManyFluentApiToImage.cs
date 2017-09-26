namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWithManyFluentApiToImage : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Images", "Service_Id", "dbo.Services");
            DropIndex("dbo.Images", new[] { "Service_Id" });
            CreateTable(
                "dbo.ServiceImages",
                c => new
                    {
                        Service_Id = c.Int(nullable: false),
                        Image_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Service_Id, t.Image_Id })
                .ForeignKey("dbo.Services", t => t.Service_Id, cascadeDelete: true)
                .ForeignKey("dbo.Images", t => t.Image_Id, cascadeDelete: true)
                .Index(t => t.Service_Id)
                .Index(t => t.Image_Id);
            
            DropColumn("dbo.Images", "Service_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "Service_Id", c => c.Int());
            DropForeignKey("dbo.ServiceImages", "Image_Id", "dbo.Images");
            DropForeignKey("dbo.ServiceImages", "Service_Id", "dbo.Services");
            DropIndex("dbo.ServiceImages", new[] { "Image_Id" });
            DropIndex("dbo.ServiceImages", new[] { "Service_Id" });
            DropTable("dbo.ServiceImages");
            CreateIndex("dbo.Images", "Service_Id");
            AddForeignKey("dbo.Images", "Service_Id", "dbo.Services", "Id");
        }
    }
}
