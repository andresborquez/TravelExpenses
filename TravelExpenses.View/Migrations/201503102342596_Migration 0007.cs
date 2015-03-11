namespace TravelExpenses.View.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration0007 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "CompanyName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "CompanyName");
        }
    }
}
