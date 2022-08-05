namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.Concrete.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            // Bu komut enable-migrations'tan sonra false olarak gelir, developer bu değeri true'ya update-database komutundan önce çevirmelidir.
        }

        protected override void Seed(DataAccessLayer.Concrete.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
