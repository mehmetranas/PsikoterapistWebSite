namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedImageClassDataannotation2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Images", "Url", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Images", "Url", c => c.String(nullable: false));
        }
    }
}
