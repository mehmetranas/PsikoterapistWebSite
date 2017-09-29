namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedIsActivePropertyOnWelcomeTextClass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WelcomeTexts", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WelcomeTexts", "IsActive", c => c.Boolean(nullable: false));
        }
    }
}
