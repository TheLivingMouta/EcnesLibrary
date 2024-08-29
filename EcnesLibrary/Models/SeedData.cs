using EcnesLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EcnesLibrary.Models;
using EcnesLibrary.Data;
using System;
using System.Linq;

namespace EcnesLibrary.Models;

    public static class SeedData
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

            var authors = new Author[]
            {
                new Author {AuthorName = "Douglas Adams"},
                new Author {AuthorName = "Griffin McElroy"},
                new Author {AuthorName = "Eichiro Oda"},
            };
            context.Author.AddRange(authors);
            context.SaveChanges();


            context.Books.AddRange
                (

                new Books
                {
                    Title = "Hitch hikers guide to the galaxy",
                    Author = authors[0].AuthorName,
                    Genre = "Science Fiction",
                    Price = 12.99M,
                },
                new Books
                {
                    Title = "The Adventure Zone: Here Be Gerblins",
                    Author = authors[1].AuthorName,
                    Genre = "Fantasy",
                    Price = 13.99M,
                },
                new Books
                {
                    Title = "The Adventure Zone: Murder Rockport Limited",
                    Author = authors[1].AuthorName,
                    Genre = "Fantasy",
                    Price = 13.99M,
                },
                new Books
                {
                    Title = "One Piece: Volume 1",
                    Author = authors[2].AuthorName,
                    Genre = "Adventure, Fantasy, Science Fiction",
                    Price = 14.99M,
                }

                );
            context.SaveChanges();
        }    
        }

    }
