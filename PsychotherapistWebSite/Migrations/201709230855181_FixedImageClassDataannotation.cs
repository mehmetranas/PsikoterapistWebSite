namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedImageClassDataannotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Images", "Name", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Images", "Name", c => c.String(maxLength: 80));
        }
    }
}
