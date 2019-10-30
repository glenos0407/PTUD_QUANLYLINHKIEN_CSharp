namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAccessory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accessory", "Cores", c => c.String());
            AddColumn("dbo.Accessory", "Threads", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accessory", "Threads");
            DropColumn("dbo.Accessory", "Cores");
        }
    }
}
