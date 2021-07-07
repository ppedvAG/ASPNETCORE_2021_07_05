using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul002
{
    public class CalcModel : PageModel
    {
        public int Ergebnis { get; set; } //Property lassen wir später in UI anzeigen


        //Standard-Init-MEthode, wenn Seite angezeigt werden soll 
        public void OnGet()
        {
            Ergebnis = 0;
        }


        //localhost:12345/Modul002/Calc&Handler=Hannes
        public void OnGetHannes() //OnGetHannes kann über einen Handler erreicht werden
        {
            Ergebnis = 42; 
        }

        public void OnPost()
        {
            int eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            int zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());
            Ergebnis = eins + zwei;
        }
    }
}
