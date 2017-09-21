namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeServiceContentLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Content", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Services", "Content", c => c.String(nullable: false, maxLength: 450));
        }
    }
}
