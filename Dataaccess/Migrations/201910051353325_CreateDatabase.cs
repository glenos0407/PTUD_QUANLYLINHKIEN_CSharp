namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accessory",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        GoodsReceiptDate = c.DateTime(nullable: false),
                        Inventory = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        WarrantyTime = c.String(),
                        CalculationUnit = c.String(),
                        Description = c.String(),
                        CPU = c.String(),
                        Generation = c.String(),
                        ProcessingSpeed = c.String(),
                        Size = c.String(),
                        Socket = c.String(),
                        Chipset = c.String(),
                        Memory = c.String(),
                        Version = c.String(),
                        Bus = c.String(),
                        BIT = c.String(),
                        Power = c.String(),
                        ProducerId = c.Int(nullable: false),
                        CategoryId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId)
                .ForeignKey("dbo.Producer", t => t.ProducerId, cascadeDelete: true)
                .Index(t => t.ProducerId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        AccessoryId = c.String(nullable: false, maxLength: 128),
                        OrderId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        AccessoryName = c.String(),
                        AccessoryCalculationUnit = c.String(),
                        AccessoryPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.AccessoryId, t.OrderId })
                .ForeignKey("dbo.Accessory", t => t.AccessoryId, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.AccessoryId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationTime = c.DateTime(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        StaffId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Staff", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        NumberPhone = c.String(nullable: false),
                        Email = c.String(),
                        Points = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(),
                        NumberPhone = c.String(nullable: false),
                        IdentifyNumber = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Password = c.String(),
                        IsActived = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Producer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        NumberPhone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accessory", "ProducerId", "dbo.Producer");
            DropForeignKey("dbo.Order", "StaffId", "dbo.Staff");
            DropForeignKey("dbo.OrderDetail", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Order", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.OrderDetail", "AccessoryId", "dbo.Accessory");
            DropForeignKey("dbo.Accessory", "CategoryId", "dbo.Category");
            DropIndex("dbo.Order", new[] { "CustomerId" });
            DropIndex("dbo.Order", new[] { "StaffId" });
            DropIndex("dbo.OrderDetail", new[] { "OrderId" });
            DropIndex("dbo.OrderDetail", new[] { "AccessoryId" });
            DropIndex("dbo.Accessory", new[] { "CategoryId" });
            DropIndex("dbo.Accessory", new[] { "ProducerId" });
            DropTable("dbo.Producer");
            DropTable("dbo.Staff");
            DropTable("dbo.Customer");
            DropTable("dbo.Order");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Category");
            DropTable("dbo.Accessory");
        }
    }
}
