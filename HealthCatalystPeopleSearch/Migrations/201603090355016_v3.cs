namespace HealthCatalystPeopleSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "byteArr", c => c.Binary());
            DropColumn("dbo.People", "picture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "picture", c => c.Binary());
            DropColumn("dbo.People", "byteArr");
        }
    }
}
