namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixInfoTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Infoes", "WellcomeText");
            DropColumn("dbo.Infoes", "PrivacyText");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Infoes", "PrivacyText", c => c.String());
            AddColumn("dbo.Infoes", "WellcomeText", c => c.String());
        }
    }
}
