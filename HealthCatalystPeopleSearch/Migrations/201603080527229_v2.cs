namespace HealthCatalystPeopleSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "firstName", c => c.String(nullable: false));
            AddColumn("dbo.People", "lastName", c => c.String(nullable: false));
            AddColumn("dbo.People", "address", c => c.String());
            AddColumn("dbo.People", "age", c => c.Int(nullable: false));
            AddColumn("dbo.People", "interests", c => c.String());
            AddColumn("dbo.People", "picture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "picture");
            DropColumn("dbo.People", "interests");
            DropColumn("dbo.People", "age");
            DropColumn("dbo.People", "address");
            DropColumn("dbo.People", "lastName");
            DropColumn("dbo.People", "firstName");
        }
    }
}
