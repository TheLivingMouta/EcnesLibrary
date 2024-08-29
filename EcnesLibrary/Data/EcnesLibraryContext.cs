using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EcnesLibrary.Models;

namespace EcnesLibrary.Data
{
    public class EcnesLibraryContext : DbContext
    {
        public EcnesLibraryContext (DbContextOptions<EcnesLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<EcnesLibrary.Models.Books> Books { get; set; }
        public DbSet<EcnesLibrary.Models.Author> Author { get; set; }
    }
}
