namespace NLayerApp.WEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteptopertieswithCustomer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "IdCompanyOrCustomer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "IdCompanyOrCustomer", c => c.Int());
        }
    }
}
