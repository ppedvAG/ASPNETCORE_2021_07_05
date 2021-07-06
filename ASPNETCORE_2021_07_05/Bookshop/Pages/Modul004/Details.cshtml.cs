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
    public class DetailsModel : PageModel
    {
        private readonly RazorPageKurs.Data.MovieDbContext _context;

        public DetailsModel(RazorPageKurs.Data.MovieDbContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Wird befüllt, bevor Page aufgerufen wird
            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
