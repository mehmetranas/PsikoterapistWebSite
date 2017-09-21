namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeServiceRequiredment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Services", "Content", c => c.String(nullable: false, maxLength: 450));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Services", "Content", c => c.String());
            AlterColumn("dbo.Services", "Name", c => c.String());
        }
    }
}
