namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubscribeMails",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        mail = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SubscribeMails");
        }
    }
}
