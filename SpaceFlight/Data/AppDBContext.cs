using Microsoft.EntityFrameworkCore;
using System;

namespace SpaceFlight.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
              : base(options)
        {
        }

        public DbSet<Models.ArticlesModel> Articles { get; set; }
        public DbSet<Models.EventsModel> Events { get; set; }
        public DbSet<Models.LaunchesModel> Launches { get; set; }

        internal object Entry<T>()
        {
            throw new NotImplementedException();
        }
    }
}
