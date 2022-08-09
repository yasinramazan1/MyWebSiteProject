namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "job", c => c.String(maxLength: 75));
            AddColumn("dbo.Authors", "aboutShort", c => c.String(maxLength: 120));
            AddColumn("dbo.Authors", "mail", c => c.String(maxLength: 75));
            AddColumn("dbo.Authors", "password", c => c.String(maxLength: 75));
            AddColumn("dbo.Authors", "phoneNumber", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "phoneNumber");
            DropColumn("dbo.Authors", "password");
            DropColumn("dbo.Authors", "mail");
            DropColumn("dbo.Authors", "aboutShort");
            DropColumn("dbo.Authors", "job");
        }
    }
}
