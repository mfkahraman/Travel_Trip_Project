namespace Travel_Trip_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hotel_val_add : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hotels", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Hotels", "Description", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hotels", "Description", c => c.String());
            AlterColumn("dbo.Hotels", "Name", c => c.String());
        }
    }
}
