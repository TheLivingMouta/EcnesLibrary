using EcnesLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EcnesLibrary.Data;
using System;
using System.Linq;

namespace EcnesLibrary.Models;

    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EcnesLibraryContext(
                serviceProvider.GetRequiredService<DbContextOptions<EcnesLibraryContext>>())) 
            {

            if (context.Books.Any())
                {
                    return;
                }
            context.Books.AddRange
                (

                new Books
                {
                    Title = "Hitch hikers guide to the galaxy",
                    Author = "Douglas Adams",
                    Genre = "Science Fiction",
                    Price = 12.99M,
                },
                new Books
                {
                    Title = "The Adventure Zone: Here Be Gerblins",
                    Author = "Griffin McElroy",
                    Genre = "Fantasy",
                    Price = 13.99M,
                },
                new Books
                {
                    Title = "The Adventure Zone: Murder Rockport Limited",
                    Author = "Griffin McElroy",
                    Genre = "Fantasy",
                    Price = 13.99M,
                },
                new Books
                {
                    Title = "One Piece: Volume 1",
                    Author = "Eiichiro Oda",
                    Genre = "Adventure, Fantasy, Science Fiction",
                    Price = 14.99M,
                }

                );
                context.SaveChanges();
            }    
        }

    }
