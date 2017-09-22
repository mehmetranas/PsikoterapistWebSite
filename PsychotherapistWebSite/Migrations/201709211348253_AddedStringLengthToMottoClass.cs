namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStringLengthToMottoClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mottoes", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Mottoes", "Text", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Mottoes", "Teller", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mottoes", "Teller", c => c.String());
            AlterColumn("dbo.Mottoes", "Text", c => c.String());
            AlterColumn("dbo.Mottoes", "Title", c => c.String());
        }
    }
}
