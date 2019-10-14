namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateIdIntAutoIncrement : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accessory", "WarrantyTime", c => c.String());
            AlterColumn("dbo.Accessory", "CalculationUnit", c => c.String());
            AlterColumn("dbo.Accessory", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accessory", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Accessory", "CalculationUnit", c => c.String(nullable: false));
            AlterColumn("dbo.Accessory", "WarrantyTime", c => c.String(nullable: false));
        }
    }
}
