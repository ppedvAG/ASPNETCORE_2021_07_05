using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul006
{
    public class RouteAttributesSampleModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("RouteAttributesDestinationSample",
                "ABC", new { year = 2019, month = 6, day = 12, title = "harrypotter" });
        }
    }
}
