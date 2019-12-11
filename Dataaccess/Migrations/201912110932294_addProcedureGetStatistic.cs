namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProcedureGetStatistic : DbMigration
    {
        public override void Up()
        {
            Sql(
                "CREATE procedure GetStatisticByDay @Year int, @Month int, @Day int " +
                "AS " +
                "Select A.Name, Inventory, Status as 'Guarantee', SUM(Quantity) as 'SoldOut' " +
                "FROM Accessory A, OrderDetail OD, [dbo].[Order] O " +
                "WHERE " +
                "   A.Id = AccessoryId AND " +
                "   DAY(CreationTime) = @Day AND " +
                "   MONTH(CreationTime) = @Month AND " +
                "   YEAR(CreationTime) = @Year " +
                "GROUP BY A.Name, DAY(CreationTime), MONTH(CreationTime), YEAR(CreationTime), Inventory, Status, A.Price " +
                "ORDER BY SUM(Quantity) DESC "
                );
            Sql(
                "CREATE procedure GetStatisticByYear @Year int " +
                "AS " +
                "Select A.Name, Inventory, Status as 'Guarantee', SUM(Quantity) as 'SoldOut' " +
                "FROM Accessory A, OrderDetail OD, [dbo].[Order] O " +
                "WHERE " +
                "    A.Id = AccessoryId AND " +
                "    YEAR(CreationTime) = @Year " +
                "GROUP BY A.Name, YEAR(CreationTime), Inventory, Status, A.Price " +
                "ORDER BY SUM(Quantity) DESC "
                );
            Sql(
                "CREATE procedure GetStatisticByMonth @Year int, @Month int " +
                "AS " +
                "Select A.Name, Inventory, Status as 'Guarantee', SUM(Quantity) as 'SoldOut' " +
                "FROM Accessory A, OrderDetail OD, [dbo].[Order] O " +
                "WHERE " +
                "    A.Id = AccessoryId AND " +
                "    MONTH(CreationTime) = @Month AND " +
                "    YEAR(CreationTime) = @Year " +
                "GROUP BY A.Name, MONTH(CreationTime), YEAR(CreationTime), Inventory, Status, A.Price " +
                "ORDER BY SUM(Quantity) DESC "
                );
        }
        
        public override void Down()
        {
        }
    }
}
