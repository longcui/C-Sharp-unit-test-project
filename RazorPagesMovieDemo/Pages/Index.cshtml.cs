using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieDemo.Data;
using RazorPagesMovieDemo.Models;

namespace RazorPagesMovieDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieDemo.Data.RazorPagesMovieDemoContext _context;

        public IndexModel(RazorPagesMovieDemo.Data.RazorPagesMovieDemoContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
