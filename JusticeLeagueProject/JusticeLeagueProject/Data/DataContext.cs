using Microsoft.EntityFrameworkCore;

namespace JusticeLeagueProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<JusticeLeagueProject> JusticeLeagueProjects { get; set; }
    }
}
