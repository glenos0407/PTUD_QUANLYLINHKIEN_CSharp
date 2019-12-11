namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProcedureGetRevenue : DbMigration
    {
        public override void Up()
        {
            Sql(
                "create procedure GetRevenueForMonthAndYear @Year int " +
                "AS " +
                "SELECT Sum(TotalPrice) as \"TotalRevenue\", MONTH(CreationTime) as 'Month', YEAR(CreationTime) as 'Year' " +
                "FROM [dbo].[Order] " +
                "WHERE YEAR(CreationTime) = @Year " +
                "GROUP BY YEAR(CreationTime) , MONTH(CreationTime)"
            );

            Sql(
                "create procedure GetRevenueForMonth @Month int, @Year int, @StartDay int, @Endday int " +
                "AS " +
                "SELECT SUM(TotalPrice) as \"TotalRevenue\", MONTH(CreationTime) as 'Month', YEAR(CreationTime) as 'Year' " +
                "FROM [dbo].[Order] " +
                "WHERE YEAR(CreationTime) = @Year AND MONTH(CreationTime) = @Month AND (DAY(CreationTime) >= @StartDay AND DAY(CreationTime) <= @Endday) " +
                "GROUP BY MONTH(CreationTime), YEAR(CreationTime) "
            );
        }
        
        public override void Down()
        {
        }
    }
}
