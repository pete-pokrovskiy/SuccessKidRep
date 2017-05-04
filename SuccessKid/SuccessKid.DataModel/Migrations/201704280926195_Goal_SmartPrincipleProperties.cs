namespace SuccessKid.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Goal_SmartPrincipleProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Goals", "IsSpecific", c => c.Boolean(nullable: false));
            AddColumn("dbo.Goals", "IsMeasurable", c => c.Boolean(nullable: false));
            AddColumn("dbo.Goals", "IsAttainable", c => c.Boolean(nullable: false));
            AddColumn("dbo.Goals", "IsRelevant", c => c.Boolean(nullable: false));
            AddColumn("dbo.Goals", "IsTimely", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Goals", "IsTimely");
            DropColumn("dbo.Goals", "IsRelevant");
            DropColumn("dbo.Goals", "IsAttainable");
            DropColumn("dbo.Goals", "IsMeasurable");
            DropColumn("dbo.Goals", "IsSpecific");
        }
    }
}
