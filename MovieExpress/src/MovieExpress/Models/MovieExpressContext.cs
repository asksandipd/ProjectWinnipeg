using Microsoft.Data.Entity;

namespace MovieExpress.Models
{
    public class MovieExpressContext : DbContext
    {
        private static bool _created = false;

        public MovieExpressContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
