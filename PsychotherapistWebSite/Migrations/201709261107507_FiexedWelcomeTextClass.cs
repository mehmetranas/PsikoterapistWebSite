namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FiexedWelcomeTextClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WelcomeTexts", "Content", c => c.String(nullable: false, maxLength: 600));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WelcomeTexts", "Content", c => c.String(nullable: false, maxLength: 210));
        }
    }
}
