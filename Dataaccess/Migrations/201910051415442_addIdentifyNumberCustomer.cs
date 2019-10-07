namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIdentifyNumberCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "IdentifyNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "IdentifyNumber");
        }
    }
}
