using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HelloWebAPI.Shared.Entities;
using HelloWebAPI.UI.Data;
using HelloWebAPI.UI.Services;

namespace HelloWebAPI.UI.Pages.MovieStore
{
    public class EditModel : PageModel
    {
        private IMovieService _service { get; set; }

        public EditModel(IMovieService service)
        {
            _service = service;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _service.GetById(id.Value);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }



            await _service.UpdateMovie(Movie.Id, Movie);

            return RedirectToPage("./Index");
        }

        
    }
}
