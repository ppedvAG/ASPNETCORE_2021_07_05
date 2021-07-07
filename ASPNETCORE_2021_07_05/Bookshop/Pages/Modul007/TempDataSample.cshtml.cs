using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul007
{
    public class TempDataSampleModel : PageModel
    {
        //[TempData] // Razor Pages Spezifisch, dass man mit Attribute ein TempData markiert
        //public string Message { get; set; }


        public void OnGet()
        {
            if (!TempData.ContainsKey("Message"))
                TempData.Add("Message", "Hello from TempDataSampleModel.Get");
            

            //Message = "Hello from TempDataSampleModel.Get";
        }
    }
}
