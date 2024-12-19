namespace Travel_Trip_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upd1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "NameSurname", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Mail", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Subject", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Message", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Message", c => c.String());
            AlterColumn("dbo.Contacts", "Subject", c => c.String());
            AlterColumn("dbo.Contacts", "Mail", c => c.String());
            AlterColumn("dbo.Contacts", "NameSurname", c => c.String());
        }
    }
}
