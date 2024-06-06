namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Datebase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PageComments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        PageID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 150),
                        Email = c.String(maxLength: 200),
                        WebSite = c.String(maxLength: 200),
                        Comment = c.String(nullable: false, maxLength: 500),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Pages", t => t.PageID, cascadeDelete: true)
                .Index(t => t.PageID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        PageID = c.Int(nullable: false, identity: true),
                        GroupeID = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 250),
                        ShortDescription = c.String(nullable: false, maxLength: 350),
                        Text = c.String(nullable: false),
                        Visit = c.Int(nullable: false),
                        ImageName = c.String(),
                        ShowInSlider = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PageID)
                .ForeignKey("dbo.PageGroups", t => t.GroupeID, cascadeDelete: true)
                .Index(t => t.GroupeID);
            
            CreateTable(
                "dbo.PageGroups",
                c => new
                    {
                        GroupeID = c.Int(nullable: false, identity: true),
                        GroupeTitle = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.GroupeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pages", "GroupeID", "dbo.PageGroups");
            DropForeignKey("dbo.PageComments", "PageID", "dbo.Pages");
            DropIndex("dbo.Pages", new[] { "GroupeID" });
            DropIndex("dbo.PageComments", new[] { "PageID" });
            DropTable("dbo.PageGroups");
            DropTable("dbo.Pages");
            DropTable("dbo.PageComments");
        }
    }
}
