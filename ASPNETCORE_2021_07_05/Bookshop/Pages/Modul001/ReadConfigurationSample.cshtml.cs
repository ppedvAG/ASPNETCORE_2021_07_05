using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookshop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Bookshop.Pages.Modul001
{
    public class ReadConfigurationSampleModel : PageModel
    {
        private readonly IConfiguration _configuration; //Microsoft.Extensions.Configuration;

        //Hier wird unsere Konfigurationseinträge stehen
        private readonly PositionOptions _positionOptions;

        private readonly SampleWebSettings _sampleWebSettings;

        //ctor + tab + tab -> Konstruktor
        public ReadConfigurationSampleModel(IConfiguration configuration, IOptions<SampleWebSettings> settingOptions)
        {
            _configuration = configuration;
            _positionOptions = new();

            _sampleWebSettings = settingOptions.Value;
        }


        public void OnGet()
        {
            _configuration.GetSection(PositionOptions.stringPosition).Bind(_positionOptions);
        }
    }
}
