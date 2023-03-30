using Microsoft.EntityFrameworkCore;

namespace MovieApp.Data
{
    public class GalleryDataContext : DbContext
    {
        public GalleryDataContext(DbContextOptions<GalleryDataContext> options):
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Picture> Pictures { get; set; }
    }
}
