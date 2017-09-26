namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWelcomeTextTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WelcomeTexts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Content = c.String(nullable: false, maxLength: 210),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WelcomeTexts");
        }
    }
}
