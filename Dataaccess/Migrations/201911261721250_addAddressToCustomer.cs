namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAddressToCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Order", "CustomerId", "dbo.Customer");
            DropIndex("dbo.Order", new[] { "CustomerId" });
            AddColumn("dbo.Customer", "Address", c => c.String());
            AlterColumn("dbo.Order", "CustomerId", c => c.Int());
            CreateIndex("dbo.Order", "CustomerId");
            AddForeignKey("dbo.Order", "CustomerId", "dbo.Customer", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "CustomerId", "dbo.Customer");
            DropIndex("dbo.Order", new[] { "CustomerId" });
            AlterColumn("dbo.Order", "CustomerId", c => c.Int(nullable: false));
            DropColumn("dbo.Customer", "Address");
            CreateIndex("dbo.Order", "CustomerId");
            AddForeignKey("dbo.Order", "CustomerId", "dbo.Customer", "Id", cascadeDelete: true);
        }
    }
}
