namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMailAttributeToInfoTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Infoes", "Mail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Infoes", "Mail");
        }
    }
}
