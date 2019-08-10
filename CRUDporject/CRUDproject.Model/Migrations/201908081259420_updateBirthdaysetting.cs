namespace CRUDproject.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBirthdaysetting : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserProfile", "Birthday", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserProfile", "Birthday", c => c.DateTime(storeType: "date"));
        }
    }
}
