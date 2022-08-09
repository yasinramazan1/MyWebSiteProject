namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "blogRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "blogRating");
        }
    }
}
