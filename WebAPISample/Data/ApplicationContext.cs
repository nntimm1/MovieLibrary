using Microsoft.EntityFrameworkCore;
using WebAPISample.Models;

namespace WebAPISample.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>()
                .HasData(
             new Models.Movie {MovieId = 1, Title = "The Departed", Genre = "Drama", Director = "Martin Scorsese" },
             new Models.Movie {MovieId = 2, Title = "The Dark Knight", Genre = "Drama", Director = "Christopher Nolan" },
             new Models.Movie {MovieId = 3, Title = "Inception", Genre = "Drama", Director = "Christopher Nolan" },
             new Models.Movie {MovieId = 4, Title = "Pineapple Express", Genre = "Comedy", Director = "David Gordon Green" },
             new Models.Movie {MovieId = 5, Title = "Die Hard", Genre = "Action", Director = "John McTiernan" });
            
        }

<<<<<<< HEAD
=======
      
>>>>>>> d7a22e8e7c4b5f62245e3094bb4c62e4d7563a4b
    }
}        


    


