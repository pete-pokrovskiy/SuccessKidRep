namespace SuccessKid.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ShortDescription = c.String(),
                        Description = c.String(),
                        UserId = c.Guid(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        Priority = c.Int(nullable: false),
                        Complexity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LasName = c.String(),
                        Login = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LifeValues",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ShortDescription = c.String(),
                        Description = c.String(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LifeValues", "UserId", "dbo.Users");
            DropForeignKey("dbo.Goals", "UserId", "dbo.Users");
            DropIndex("dbo.LifeValues", new[] { "UserId" });
            DropIndex("dbo.Goals", new[] { "UserId" });
            DropTable("dbo.LifeValues");
            DropTable("dbo.Users");
            DropTable("dbo.Goals");
        }
    }
}
