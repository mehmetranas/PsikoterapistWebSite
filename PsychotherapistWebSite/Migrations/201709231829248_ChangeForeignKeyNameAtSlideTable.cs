
namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeForeignKeyNameAtSlideTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Slides", "Motto_Id", "dbo.Mottoes");
            DropIndex("dbo.Slides", new[] { "Motto_Id" });
            RenameColumn(table: "dbo.Slides", name: "Image_Id", newName: "ImageId");
            RenameColumn(table: "dbo.Slides", name: "Motto_Id", newName: "MottoId");
            RenameIndex(table: "dbo.Slides", name: "IX_Image_Id", newName: "IX_ImageId");
            AlterColumn("dbo.Slides", "MottoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Slides", "MottoId");
            AddForeignKey("dbo.Slides", "MottoId", "dbo.Mottoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Slides", "MottoId", "dbo.Mottoes");
            DropIndex("dbo.Slides", new[] { "MottoId" });
            AlterColumn("dbo.Slides", "MottoId", c => c.Int());
            RenameIndex(table: "dbo.Slides", name: "IX_ImageId", newName: "IX_Image_Id");
            RenameColumn(table: "dbo.Slides", name: "MottoId", newName: "Motto_Id");
            RenameColumn(table: "dbo.Slides", name: "ImageId", newName: "Image_Id");
            CreateIndex("dbo.Slides", "Motto_Id");
            AddForeignKey("dbo.Slides", "Motto_Id", "dbo.Mottoes", "Id");
        }
    }
}
