using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Assignment5Project.Data;
using System;
using System.Linq;


namespace Assignment5Project.Models
{
    public static class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider) 
        {
            using (var context = new Assignment5ProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Assignment5ProjectContext>>())) 
            {
                //look for any music
                if (context.Music.Any()) 
                {
                    return;     //db has been seeded
                }
                context.Music.AddRange(
                    new Music
                    {
                        Title = "Iron Man",
                        Artist = "Black Sabbath",
                        Genre = "Metal",
                        ReleaseDate = DateTime.Parse("1970-9-17"),
                        Length = "5:55",
                        Price = 1.99m
                    },
                    new Music 
                    {
                        Title = "Everlong",
                        Artist = "Foo Fighters",
                        Genre = "Rock",
                        ReleaseDate = DateTime.Parse("1997-5-20"),
                        Length = "4:10",
                        Price = 1.99m
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
