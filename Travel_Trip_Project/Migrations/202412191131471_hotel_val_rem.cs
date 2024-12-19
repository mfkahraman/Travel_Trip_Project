namespace Travel_Trip_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hotel_val_rem : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hotels", "Name", c => c.String());
            AlterColumn("dbo.Hotels", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hotels", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Hotels", "Name", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
