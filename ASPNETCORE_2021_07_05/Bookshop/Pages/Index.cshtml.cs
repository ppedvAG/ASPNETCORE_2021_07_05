using DependecyInjectionSample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageKurs.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICar _car; 

        public IndexModel(ILogger<IndexModel> logger, ICar car) //ILogger ist im IOC Container hinterlegt 
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
