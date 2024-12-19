namespace Travel_Trip_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class val_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 500),
                        ImageUrl = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 500),
                        ImageUrl = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AlterColumn("dbo.Abouts", "PhotoUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Admins", "User", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Admins", "Password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Blogs", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Blogs", "Description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Blogs", "BlogImage", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Comments", "UserName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Comments", "Mail", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Comments", "Context", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "Context", c => c.String());
            AlterColumn("dbo.Comments", "Mail", c => c.String());
            AlterColumn("dbo.Comments", "UserName", c => c.String());
            AlterColumn("dbo.Blogs", "BlogImage", c => c.String());
            AlterColumn("dbo.Blogs", "Description", c => c.String());
            AlterColumn("dbo.Blogs", "Title", c => c.String());
            AlterColumn("dbo.Admins", "Password", c => c.String());
            AlterColumn("dbo.Admins", "User", c => c.String());
            AlterColumn("dbo.Abouts", "Description", c => c.String());
            AlterColumn("dbo.Abouts", "PhotoUrl", c => c.String());
            DropTable("dbo.Restaurants");
            DropTable("dbo.Hotels");
        }
    }
}
