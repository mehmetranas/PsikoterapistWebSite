namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CahengeAdressClassRequiretment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Adresses", "Place", c => c.String(nullable: false));
            AlterColumn("dbo.Adresses", "Town", c => c.String(nullable: false));
            AlterColumn("dbo.Adresses", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Infoes", "PersonName", c => c.String(nullable: false));
            AlterColumn("dbo.Infoes", "AboutMe", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Infoes", "AboutMe", c => c.String());
            AlterColumn("dbo.Infoes", "PersonName", c => c.String());
            AlterColumn("dbo.Adresses", "City", c => c.String());
            AlterColumn("dbo.Adresses", "Town", c => c.String());
            AlterColumn("dbo.Adresses", "Place", c => c.String());
        }
    }
}
