namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAvatar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accessory", "Avatar", c => c.String());
            AddColumn("dbo.Staff", "Avatar", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Staff", "Avatar");
            DropColumn("dbo.Accessory", "Avatar");
        }
    }
}
