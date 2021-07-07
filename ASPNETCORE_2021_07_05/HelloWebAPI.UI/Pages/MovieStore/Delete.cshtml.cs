using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HelloWebAPI.Shared.Entities;
using HelloWebAPI.UI.Data;
using HelloWebAPI.UI.Services;

namespace HelloWebAPI.UI.Pages.MovieStore
{
    public class DeleteModel : PageModel
    {
        private IMovieService _service { get; set; }

        public DeleteModel(IMovieService service)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _service.GetById(id.Value);

            if (Movie != null)
            {
                await _service.DeleteMovie(Movie.Id);
                
            }

            return RedirectToPage("./Index");
        }
    }
}
