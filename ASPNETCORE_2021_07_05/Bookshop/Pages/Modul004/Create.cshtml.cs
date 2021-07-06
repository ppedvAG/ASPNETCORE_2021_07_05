using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageKurs.Data;
using RazorPageKurs.Models;

namespace RazorPageKurs.Pages.Modul004
{
    public class CreateModel : PageModel
    {
        private readonly RazorPageKurs.Data.MovieDbContext _context;

        public CreateModel(RazorPageKurs.Data.MovieDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            // Wenn einige Properties befüllt werden müssen, dann hier!
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)  //Serverseitige Validierung
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
