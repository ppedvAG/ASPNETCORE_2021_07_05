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
    public class SessionSampleModel : PageModel
    {
        public void OnGet()
        {
            //SetInt32 ist eine Erweiterungsmethode die in dem Assembly Microsoft.AspNetCore.Http vorliegt
            HttpContext.Session.SetInt32("age", 33);
            HttpContext.Session.SetString("mitarbeiterDesMonats", "Donald Duck");

            Movie movie = new Movie { Id = 123, Title = "Jurrasic Park", Price = 19.99m, PuplisherYear = DateTime.Now.Year };

            string jsonString = JsonSerializer.Serialize(movie);
            HttpContext.Session.SetString("MyMovie", jsonString);
        }
    }


    
}
