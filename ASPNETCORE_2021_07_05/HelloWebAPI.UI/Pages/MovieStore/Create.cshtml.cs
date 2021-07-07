using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HelloWebAPI.Shared.Entities;
using HelloWebAPI.UI.Data;
using HelloWebAPI.UI.Services;

namespace HelloWebAPI.UI.Pages.MovieStore
{
    public class CreateModel : PageModel
    {
        private IMovieService _service { get; set; }

        public CreateModel(IMovieService service)
        {
            _service = service;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _service.InsertMovie(Movie);

            return RedirectToPage("./Index");
        }
    }
}
