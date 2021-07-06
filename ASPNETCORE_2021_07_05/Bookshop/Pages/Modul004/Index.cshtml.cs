using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RazorPageKurs.Data;
using RazorPageKurs.Models;

namespace RazorPageKurs.Pages.Modul004
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageKurs.Data.MovieDbContext _context;

        public IndexModel(RazorPageKurs.Data.MovieDbContext context) // Dependency Injection (Instanz kommt aus dem IOC Container) 
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } //Diese wird vom Frontend aufgerufen und wird als Tabelle dargestellt

        public async Task OnGetAsync()
        {
            //Synchron 
            //List<Movie> myMovies = _context.Movie.ToList(); 
            
            //TPL Asynchron 
            Task<List<Movie>> task = _context.Movie.ToListAsync();
            task.Wait(); //warten bis Task fertig fertig ist 
            Movie = task.Result;

            //async-await Pattern
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
