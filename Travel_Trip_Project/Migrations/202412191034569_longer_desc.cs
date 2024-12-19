namespace Travel_Trip_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class longer_desc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Hotels", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Restaurants", "Description", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restaurants", "Description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Hotels", "Description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Blogs", "Description", c => c.String(nullable: false, maxLength: 500));
        }
    }
}
