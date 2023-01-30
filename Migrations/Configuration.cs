namespace MVCGlAtelier2023.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCGlAtelier2023.Models.dbAtelier2023Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; //cela ns permet de faire la migration de classes (mais en deploiement on remet sa a false)
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(MVCGlAtelier2023.Models.dbAtelier2023Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
