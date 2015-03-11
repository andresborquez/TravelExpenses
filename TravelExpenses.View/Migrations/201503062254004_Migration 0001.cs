namespace TravelExpenses.View.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration0001 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Companies");
            AddColumn("dbo.Companies", "CompanyID", c => c.Int(nullable: false, identity: false));
            AddPrimaryKey("dbo.Companies", "CompanyID");
            DropColumn("dbo.Companies", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Companies", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Companies");
            DropColumn("dbo.Companies", "CompanyID");
            AddPrimaryKey("dbo.Companies", "ID");
        }
    }
}
