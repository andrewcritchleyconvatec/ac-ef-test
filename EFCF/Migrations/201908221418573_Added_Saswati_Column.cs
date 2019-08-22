namespace EFCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Saswati_Column : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "SaswatiColumn", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "SaswatiColumn");
        }
    }
}
