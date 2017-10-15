namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWorkInfoToWelcomeTextTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WelcomeTexts", "DaysHour", c => c.String(nullable: false, maxLength: 25));
            AddColumn("dbo.WelcomeTexts", "NoteForClosedDay", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WelcomeTexts", "NoteForClosedDay");
            DropColumn("dbo.WelcomeTexts", "DaysHour");
        }
    }
}
