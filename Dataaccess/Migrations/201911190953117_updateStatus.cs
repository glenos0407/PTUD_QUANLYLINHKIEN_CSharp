namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateStatus : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accessory", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accessory", "Status", c => c.Boolean(nullable: false));
        }
    }
}
