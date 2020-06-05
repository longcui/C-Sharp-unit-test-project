using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieDemo.Models;

namespace RazorPagesMovieDemo.Data
{
    public class RazorPagesMovieDemoContext : DbContext
    {
        public RazorPagesMovieDemoContext (DbContextOptions<RazorPagesMovieDemoContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovieDemo.Models.Movie> Movie { get; set; }
    }
}
