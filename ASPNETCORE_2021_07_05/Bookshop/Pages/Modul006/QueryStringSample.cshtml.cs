using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul006
{
    //STARTSEITE
    public class QueryStringSampleModel : PageModel
    {

        //http call ->: https://localhost:5001/Modul006/QueryStringSample?month=2&year=1
        public void OnGet(int year, int month)
        {
            
        }
    }
}
