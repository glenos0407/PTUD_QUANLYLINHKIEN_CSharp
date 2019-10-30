namespace Dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProducer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Producer", "Address");
            DropColumn("dbo.Producer", "NumberPhone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Producer", "NumberPhone", c => c.String(nullable: false));
            AddColumn("dbo.Producer", "Address", c => c.String(nullable: false));
        }
    }
}
