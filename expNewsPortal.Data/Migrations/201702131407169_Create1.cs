namespace expNewsPortal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImageItems",
                c => new
                    {
                        ImageItemId = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        NewsItem_NewsItemId = c.Int(),
                    })
                .PrimaryKey(t => t.ImageItemId)
                .ForeignKey("dbo.NewsItems", t => t.NewsItem_NewsItemId)
                .Index(t => t.NewsItem_NewsItemId);
            
            CreateTable(
                "dbo.NewsItems",
                c => new
                    {
                        NewsItemId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        ShortDescription = c.String(maxLength: 250),
                        ViewCount = c.Int(nullable: false),
                        Description = c.String(maxLength: 2000),
                        IsActive = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        ImageItem = c.String(maxLength: 255),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.NewsItemId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewsItems", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.ImageItems", "NewsItem_NewsItemId", "dbo.NewsItems");
            DropIndex("dbo.NewsItems", new[] { "User_UserId" });
            DropIndex("dbo.ImageItems", new[] { "NewsItem_NewsItemId" });
            DropTable("dbo.NewsItems");
            DropTable("dbo.ImageItems");
        }
    }
}
