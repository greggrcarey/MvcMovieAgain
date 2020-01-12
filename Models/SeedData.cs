using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) 
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
                {
                    if(context.Movie.Any()){
                        return;
                    }
                    context.Movie.AddRange(
                          new Movie
                    {
                        Title = "Better Off Dead...",
                        ReleaseDate = DateTime.Parse("1985-10-11"),
                        Genre = "Comedy",
                        Price = 7.99M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "Nothing But Trouble ",
                        ReleaseDate = DateTime.Parse("1991-2-15"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Bloodbath at the House of Death",
                        ReleaseDate = DateTime.Parse("1984-3-30"),
                        Genre = "Horror",
                        Price = 9.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Hard To Kill",
                        ReleaseDate = DateTime.Parse("1990-2-9"),
                        Genre = "Action",
                        Price = 3.99M,
                        Rating = "R"
                    }

                    );
                    context.SaveChanges();

                }
        }
    }
}