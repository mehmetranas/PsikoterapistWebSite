namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGeoInfoToAdressTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Adresses", "Latitude", c => c.String(nullable: false));
            AddColumn("dbo.Adresses", "LongiTude", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Adresses", "LongiTude");
            DropColumn("dbo.Adresses", "Latitude");
        }
    }
}
