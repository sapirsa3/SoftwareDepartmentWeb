namespace projectnetwork.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<projectnetwork.Dal.LoginDal>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "projectnetwork.Dal.LoginDal";
        }

        protected override void Seed(projectnetwork.Dal.LoginDal context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
