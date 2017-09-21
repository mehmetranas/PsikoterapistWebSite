namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMottoTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mottoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        Teller = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Slides", "Motto_Id", c => c.Int());
            AlterColumn("dbo.Slides", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Slides", "Url", c => c.String(nullable: false));
            CreateIndex("dbo.Slides", "Motto_Id");
            AddForeignKey("dbo.Slides", "Motto_Id", "dbo.Mottoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Slides", "Motto_Id", "dbo.Mottoes");
            DropIndex("dbo.Slides", new[] { "Motto_Id" });
            AlterColumn("dbo.Slides", "Url", c => c.String());
            AlterColumn("dbo.Slides", "Title", c => c.String());
            DropColumn("dbo.Slides", "Motto_Id");
            DropTable("dbo.Mottoes");
        }
    }
}
