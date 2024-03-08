using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCApp.Data;
using System;
using System.Linq;

namespace MVCApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCAppContext>>()))
            {
                //Look for any movies
                if (context.Movie.Any())
                {
                    return;//Db has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Dune",
                        ReleaseDate = DateTime.Parse("2018-2-12"),
                        Genre = "Action",
                        Price = 40.3M, 
                        Rating = "M"
                    },
                    new Movie
                    {
                        Title = "El sorprendente Hombre Araña",
                        ReleaseDate = DateTime.Parse("2008-5-18"),
                        Genre = "SuperHeroes",
                        Price = 90.40M,
                        Rating = "M"
                    },
                    new Movie
                    {
                        Title = "Iron Man",
                        ReleaseDate = DateTime.Parse("2012-6-20"),
                        Genre = "SuperHeroes",
                        Price = 120M,
                        Rating = "M"
                    },
                    new Movie
                    {
                        Title = "Toy Story",
                        ReleaseDate = DateTime.Parse("2000-10-20"),
                        Genre = "Animation",
                        Price = 80.20M,
                        Rating = "M"
                    },
                    new Movie
                    {
                        Title = "Cars 3",
                        ReleaseDate = DateTime.Parse("2017-10-2"),
                        Genre = "Animation",
                        Price = 120M,
                        Rating = "M"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
