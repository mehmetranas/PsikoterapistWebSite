namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixDateTimeAtMessageClass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Messages", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "DateTime", c => c.DateTime(nullable: false));
        }
    }
}
