using MovieApp.Data;

namespace MovieApp
{
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<GalleryDataContext>();
            context.Database.EnsureCreated();
            //AddMovies(context);
        }
/*
        private static void AddMovies(GalleryDataContext context)
        {
            var movie = context.Movies.FirstOrDefault();
            if (movie != null) return;

            context.Movies.Add(new Gallery
            {
                Title = "The Shawshank Redemption",
                Year = 1994,
                Summary = "Banker Andy Dufresne is arrested for killing his wife and her lover. After a hard adjustment, he tries to improve the conditions of the prison and to give hope to his companions.",
                Actors = new List<Author>
                {
                    new Author { Fullname = "Morgan Freeman"},
                    new Author { Fullname = "Tim Robbins"}
                }
            });

            context.Movies.Add(new Gallery
            {
                Title = "The Godfather",
                Year = 1972,
                Summary = "The aging patriarch of a New York mafia dynasty passes the torch of his underground empire to his reluctant son",
                Actors = new List<Author>
                {
                    new Author { Fullname = "Marlon Brando" },
                    new Author { Fullname = "Al Pacino " },
                }
            });

            context.Movies.Add(new Gallery
            {
                Title = "The Dark Knight",
                Year = 2008,
                Summary = "When a threat better known as the Joker emerges from his mysterious past and unleashes chaos on Gotham City, Batman must face the greatest of psychological and physical challenges to fight injustice.",
                Actors = new List<Author>
                {
                    new Author { Fullname = "Marlon Brando" },
                    new Author { Fullname = "Al Pacino " },
                }
            });

            context.SaveChanges();
        }
*/
    }
}
