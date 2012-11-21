namespace dbdit.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebMatrix.WebData;
    using System.Web;
    using System.Web.Security;

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
