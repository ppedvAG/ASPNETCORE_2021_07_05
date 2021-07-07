using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageKurs.Models;

namespace RazorPageKurs.Pages.Modul007
{
    public class SessionDestinationModel : PageModel
    {
        public void OnGet()
        {
            //auslesen
            int? age = HttpContext.Session.GetInt32("age");
            string mitarbeiter = HttpContext.Session.GetString("mitarbeiterDesMonats");

            string jsonString = HttpContext.Session.GetString("MyMovie");
            Movie movie = JsonSerializer.Deserialize<Movie>(jsonString);

        }
    }
}
