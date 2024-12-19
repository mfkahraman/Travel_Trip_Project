namespace Travel_Trip_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class url_req_removed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "PhotoUrl", c => c.String());
            AlterColumn("dbo.Blogs", "BlogImage", c => c.String(maxLength: 250));
            AlterColumn("dbo.Hotels", "ImageUrl", c => c.String());
            AlterColumn("dbo.Restaurants", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restaurants", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Hotels", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Blogs", "BlogImage", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Abouts", "PhotoUrl", c => c.String(nullable: false));
        }
    }
}
