namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "cv", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "cv");
        }
    }
}
