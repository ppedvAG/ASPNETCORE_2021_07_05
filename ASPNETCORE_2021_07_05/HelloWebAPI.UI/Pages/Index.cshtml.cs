using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloWebAPI.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //Böser Quellcode
            using (HttpClient client = new HttpClient())
            {

            } //Dispose() -> das funktioniert nicht so gut :-)
              //Weil HttpClient, verwendet WebSocket und diese werden nicht sofort freigegeben
        }
    }
}
