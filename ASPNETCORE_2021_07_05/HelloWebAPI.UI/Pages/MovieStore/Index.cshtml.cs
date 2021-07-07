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
    public class IndexModel : PageModel
    {
        private IMovieService _service { get; set; }

        public IndexModel(IMovieService service)
        {
            _service = service;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _service.GetAll();
        }
    }
}
