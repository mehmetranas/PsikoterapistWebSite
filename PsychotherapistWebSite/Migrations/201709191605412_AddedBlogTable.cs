namespace PsychotherapistWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBlogTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        Writter = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Categories", "Blog_Id", c => c.Int());
            AddColumn("dbo.Comments", "Blog_Id", c => c.Int());
            CreateIndex("dbo.Categories", "Blog_Id");
            CreateIndex("dbo.Comments", "Blog_Id");
            AddForeignKey("dbo.Categories", "Blog_Id", "dbo.Blogs", "Id");
            AddForeignKey("dbo.Comments", "Blog_Id", "dbo.Blogs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Blog_Id", "dbo.Blogs");
            DropForeignKey("dbo.Categories", "Blog_Id", "dbo.Blogs");
            DropIndex("dbo.Comments", new[] { "Blog_Id" });
            DropIndex("dbo.Categories", new[] { "Blog_Id" });
            DropColumn("dbo.Comments", "Blog_Id");
            DropColumn("dbo.Categories", "Blog_Id");
            DropTable("dbo.Blogs");
        }
    }
}
