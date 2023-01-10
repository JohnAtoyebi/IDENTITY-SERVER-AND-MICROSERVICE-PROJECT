using Movies.API.Model;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Movies.API.Data
{
    public class MoviesContextSeed
    {
        public static void SeedAsync(MoviesAPIContext moviesContext)
        {
            if (!moviesContext.Movie.Any())
            {
                var movies = new List<Movie>
                {
                    new Movie
                    {
                        Id = 1,
                        Genre = "Drama",
                        Title = "Winning Touch",
                        Rating = "8.12",
                        ImageUrl = "images/url",
                        ReleaseDate = DateTime.Now,
                        Owner = "Jay"
                    },
                    new Movie
                    {
                        Id = 2,
                        Genre = "Love",
                        Title = "Loving Soul",
                        Rating = "10.1",
                        ImageUrl = "images/url",
                        ReleaseDate = DateTime.Now,
                        Owner = "Sam"
                    },
                    new Movie
                    {
                        Id = 3,
                        Genre = "Games",
                        Title = "Gaming Soul",
                        Rating = "40.1",
                        ImageUrl = "images/url",
                        ReleaseDate = new DateTime(2022, 3, 4),
                        Owner = "Kay"
                    }
                };
                moviesContext.Movie.AddRange(movies);
                moviesContext.SaveChanges();
            }
        }
    }
}
