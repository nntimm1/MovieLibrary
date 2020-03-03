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
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Movie>()
            //    .HasData(
            // //new Models.Movie {MovieId = 1, Title = "The Departed", Genre = "Drama", Director = "Martin Scorsese" },
            // new Models.Movie {MovieId = 2, Title = "The Dark Knight", Genre = "Drama", Director = "Christopher Nolan" },
            // new Models.Movie {MovieId = 3, Title = "Inception", Genre = "Drama", Director = "Christopher Nolan" },
            // new Models.Movie {MovieId = 4, Title = "Pineapple Express", Genre = "Comedy", Director = "David Gordon Green" },
            // new Models.Movie {MovieId = 5, Title = "Die Hard", Genre = "Action", Director = "John McTiernan" });


            // Seed data - needs migration
            //modelBuilder.Entity<Movie>
            // .HasData(
            // new Movie { Fill All Properties }
            // );
            // View PlayerTracker project for example



        }
    }
}


    


