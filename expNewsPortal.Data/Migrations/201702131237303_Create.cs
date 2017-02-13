namespace expNewsPortal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 16),
                        CreateDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Rol_RoleId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Roles", t => t.Rol_RoleId)
                .Index(t => t.Rol_RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Rol_RoleId", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "Rol_RoleId" });
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}
