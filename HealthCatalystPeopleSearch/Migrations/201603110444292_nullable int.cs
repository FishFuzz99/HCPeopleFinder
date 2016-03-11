namespace HealthCatalystPeopleSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullableint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "age", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "age", c => c.Int(nullable: false));
        }
    }
}
