using System.Data.Entity;
using dbdit.DAL.Entities;

namespace dbdit.DAL
{
    public class DbdItDbContext: DbContext
    {
        public DbSet<UserProfile> UserProfile { get; set; }

        public DbdItDbContext()
            : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
    }
}
