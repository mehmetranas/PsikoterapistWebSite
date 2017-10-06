namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDisplayOnHomePagePropertyToFaqClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Faqs", "IsDisplayOnHomePage", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faqs", "IsDisplayOnHomePage");
        }
    }
}
