using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageKurs.Data;
using RazorPageKurs.Models;

namespace RazorPageKurs.Pages.Modul004
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageKurs.Data.MovieDbContext _context;

        public IndexModel(RazorPageKurs.Data.MovieDbContext context)
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
