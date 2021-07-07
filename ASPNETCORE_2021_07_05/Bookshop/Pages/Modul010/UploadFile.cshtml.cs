using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul010
{
    public class UploadFileModel : PageModel
    {
        public void OnGet()
        {
        }


        public IActionResult OnPost(IFormFile datei)
        {
            FileInfo fileInfo = new FileInfo(datei.FileName);

            var speicherePfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\" + fileInfo.Name;

            using (var fs = new FileStream(speicherePfad, FileMode.Create))
            {
                datei.CopyTo(fs);
            }


            return RedirectToPage("UploadFile");
        }
    }
}
