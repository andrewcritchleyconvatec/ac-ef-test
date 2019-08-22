namespace EFCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAdditionalFieldsToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Surname", c => c.String());
            AddColumn("dbo.Customers", "AddressLine1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "AddressLine1");
            DropColumn("dbo.Customers", "Surname");
        }
    }
}
