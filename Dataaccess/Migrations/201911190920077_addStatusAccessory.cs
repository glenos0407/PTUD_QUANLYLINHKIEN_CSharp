namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStatusAccessory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accessory", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accessory", "Status");
        }
    }
}
