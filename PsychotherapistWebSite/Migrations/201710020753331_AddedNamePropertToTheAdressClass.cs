namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNamePropertToTheAdressClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Adresses", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Adresses", "Name");
        }
    }
}
