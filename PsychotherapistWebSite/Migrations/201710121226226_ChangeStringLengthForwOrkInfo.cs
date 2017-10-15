namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStringLengthForwOrkInfo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WelcomeTexts", "DaysHour", c => c.String(nullable: false, maxLength: 35));
            AlterColumn("dbo.WelcomeTexts", "NoteForClosedDay", c => c.String(nullable: false, maxLength: 35));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WelcomeTexts", "NoteForClosedDay", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.WelcomeTexts", "DaysHour", c => c.String(nullable: false, maxLength: 25));
        }
    }
}
