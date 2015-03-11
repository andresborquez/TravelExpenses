namespace TravelExpenses.View.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration0002 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "CompanyID", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
        }
    }
}
