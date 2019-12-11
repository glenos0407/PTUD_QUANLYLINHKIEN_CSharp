namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDatabase1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Order", "TotalPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Order", "TotalPrice", c => c.Double());
        }
    }
}
