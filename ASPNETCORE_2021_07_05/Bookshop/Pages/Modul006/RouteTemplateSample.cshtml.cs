using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul006
{
    public class RouteTemplateSampleModel : PageModel
    {
        //public void OnGet(string title)
        //{
        //}

        //https://localhost:xxxxx/Modul008/RouteTemplatesSample/2019/8/12/HarryPotter
        public void OnGet(int year, int month, int day, string title)
        {
        }
    }
}
