namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeRole : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Staff", "Role");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Staff", "Role", c => c.Int(nullable: false));
        }
    }
}
