namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAdressIdToInfoClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Infoes", "Adress_Id", "dbo.Adresses");
            DropIndex("dbo.Infoes", new[] { "Adress_Id" });
            RenameColumn(table: "dbo.Infoes", name: "Adress_Id", newName: "AdressId");
            AlterColumn("dbo.Infoes", "AdressId", c => c.Int(nullable: false));
            CreateIndex("dbo.Infoes", "AdressId");
            AddForeignKey("dbo.Infoes", "AdressId", "dbo.Adresses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Infoes", "AdressId", "dbo.Adresses");
            DropIndex("dbo.Infoes", new[] { "AdressId" });
            AlterColumn("dbo.Infoes", "AdressId", c => c.Int());
            RenameColumn(table: "dbo.Infoes", name: "AdressId", newName: "Adress_Id");
            CreateIndex("dbo.Infoes", "Adress_Id");
            AddForeignKey("dbo.Infoes", "Adress_Id", "dbo.Adresses", "Id");
        }
    }
}
