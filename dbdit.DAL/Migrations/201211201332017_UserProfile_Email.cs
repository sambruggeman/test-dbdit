namespace dbdit.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserProfile_Email : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfiles", "Email", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfiles", "Email");
        }
    }
}
