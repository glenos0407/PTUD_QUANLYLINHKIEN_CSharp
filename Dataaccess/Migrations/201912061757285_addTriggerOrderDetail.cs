namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTriggerOrderDetail : DbMigration
    {
        public override void Up()
        {
            Sql(
				"CREATE TRIGGER UpdateInforOrderDetail ON[dbo].[OrderDetail] AFTER INSERT " +
				"AS " + 
				"BEGIN " +
					"UPDATE[dbo].[OrderDetail] " +
					"SET AccessoryName = ( " +
					"	SELECT Name " + 
					"	FROM Accessory " +
					"	WHERE[dbo].[OrderDetail].AccessoryId = [dbo].[Accessory].Id " +
					"), " +
					"AccessoryCalculationUnit = ( " +
					"	SELECT CalculationUnit " +
					"	FROM Accessory " +
					"	WHERE[dbo].[OrderDetail].AccessoryId = [dbo].[Accessory].Id " +
					"), " +
					"AccessoryPrice = ( " +
					"	SELECT Price " +
					"	FROM Accessory " +
					"	WHERE[dbo].[OrderDetail].AccessoryId = [dbo].[Accessory].Id " +
					") " +
					"FROM[dbo].[OrderDetail] " +
					"JOIN inserted ON[dbo].[OrderDetail].AccessoryId = inserted.AccessoryId " +
					"AND[dbo].[OrderDetail].OrderId = inserted.OrderId " +
					"WHERE[dbo].[OrderDetail].AccessoryId = inserted.AccessoryId " + 
					"AND[dbo].[OrderDetail].OrderId = inserted.OrderId " +
					"END "
                );
			Sql(
				"CREATE TRIGGER UpdateTotalPriceOrder ON[dbo].[OrderDetail] AFTER INSERT " +
				"AS " +
				"BEGIN " +
				"	UPDATE[dbo].[Order] " +
				"	SET TotalPrice = 0 + ( " +
				"		SELECT SUM(Quantity * AccessoryPrice) " +
				"		FROM OrderDetail " +
				"		WHERE[dbo].[Order].Id = OrderId " +
				"	) " +
				"	FROM[dbo].[Order] " +
				"	JOIN inserted ON[dbo].[Order].Id = inserted.OrderId " +
				"END "
				);
        }
        
        public override void Down()
        {
        }
    }
}
