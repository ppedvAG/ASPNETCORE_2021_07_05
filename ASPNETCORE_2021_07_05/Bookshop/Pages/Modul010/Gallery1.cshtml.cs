using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul010
{
    public class Gallery1Model : PageModel
    {
        public List<string> Bilder { get; set; }
        
        public void OnGet()
        {
            var pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images";
            string[] allFiles = Directory.GetFiles(pfad);

            if (Bilder == null)
                Bilder = new List<string>();

            Bilder.AddRange(allFiles);
        }
    }
}
