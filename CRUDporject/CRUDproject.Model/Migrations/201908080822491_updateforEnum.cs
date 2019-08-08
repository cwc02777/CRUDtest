namespace CRUDproject.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateforEnum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "Gender", c => c.Int(nullable: false));
            DropColumn("dbo.UserProfile", "Sex");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "Sex", c => c.Byte());
            DropColumn("dbo.UserProfile", "Gender");
        }
    }
}
