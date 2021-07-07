using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul007
{
    public class ViewDataSampleModel : PageModel
    {
        public void OnGet()
        {
            ViewData.Add("Email", "KevinW@PPEDV.de");
        }
    }
}
