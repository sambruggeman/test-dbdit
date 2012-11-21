namespace dbdit.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<dbdit.DAL.DbdItDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(dbdit.DAL.DbdItDbContext context)
        {

        }
    }
}
