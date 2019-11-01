namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAccessory1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Accessory", "Description");
            DropColumn("dbo.Accessory", "Generation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accessory", "Generation", c => c.String());
            AddColumn("dbo.Accessory", "Description", c => c.String());
        }
    }
}
