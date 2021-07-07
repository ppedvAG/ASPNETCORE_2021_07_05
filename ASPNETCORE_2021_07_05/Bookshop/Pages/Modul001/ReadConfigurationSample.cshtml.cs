using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPageKurs.Models;
using DependecyInjectionSample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace RazorPageKurs.Pages.Modul001
{
    public class ReadConfigurationSampleModel : PageModel
    {
        private readonly IConfiguration _configuration; //Microsoft.Extensions.Configuration;

        //Hier wird unsere Konfigurationseinträge stehen
        private readonly PositionOptions _positionOptions;

        private readonly SampleWebSettings _sampleWebSettings;

        private readonly ICarService _carService;

        private readonly ICar _funCar; 

        //ctor + tab + tab -> Konstruktor
        public ReadConfigurationSampleModel(IConfiguration configuration, IOptions<SampleWebSettings> settingOptions, ICarService carService, ICar car)
        {
            _configuration = configuration;
            _positionOptions = new();

            _sampleWebSettings = settingOptions.Value;
            _carService = carService;

            _funCar = car;

        }


        public void OnGet()
        {
            _configuration.GetSection(PositionOptions.stringPosition).Bind(_positionOptions);
        }
    }
}
