namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImageArrayToInfoCLass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InfoImages",
                c => new
                    {
                        Info_Id = c.Int(nullable: false),
                        Image_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Info_Id, t.Image_Id })
                .ForeignKey("dbo.Infoes", t => t.Info_Id, cascadeDelete: true)
                .ForeignKey("dbo.Images", t => t.Image_Id, cascadeDelete: true)
                .Index(t => t.Info_Id)
                .Index(t => t.Image_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InfoImages", "Image_Id", "dbo.Images");
            DropForeignKey("dbo.InfoImages", "Info_Id", "dbo.Infoes");
            DropIndex("dbo.InfoImages", new[] { "Image_Id" });
            DropIndex("dbo.InfoImages", new[] { "Info_Id" });
            DropTable("dbo.InfoImages");
        }
    }
}
