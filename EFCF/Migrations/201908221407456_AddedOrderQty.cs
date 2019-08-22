namespace EFCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOrderQty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderNumberQty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "OrderNumberQty");
        }
    }
}
