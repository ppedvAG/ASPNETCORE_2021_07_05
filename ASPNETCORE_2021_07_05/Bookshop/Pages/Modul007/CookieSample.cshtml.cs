using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageKurs.Pages.Modul007
{
    public class CookieSampleModel : PageModel
    {
        //private readonly IHttpContextAccessor _httpContextAccessor;
        //public CookieSampleModel(IHttpContextAccessor httpContextAccessor)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //}
        
        [BindProperty]
        public string EmailAddress { get; set; }

        public void OnGet()
        {
            
            //Einlesen mit Options
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30) //Wie lange soll das Cookie gespeichert bleiben
            };

            //Max Size eines Cookies 4096 bytes
            Response.Cookies.Append("MyCookie", "value1abcgvhgcg", cookieOptions);
            
            //Beispiel via httpContextAccesor
            //_httpContextAccessor.HttpContext.Response.Cookies.Append("Kevin", DateTime.Now.ToShortTimeString(), options);

            //string time = _httpContextAccessor.HttpContext.Request.Cookies["Kevin"];
        }


        public void OnPost()
        {
            //Beispiel via httpContextAccesor
            //string time = _httpContextAccessor.HttpContext.Request.Cookies["Kevin"];

            var cookieValue = Request.Cookies["MyCookie"];
        }

    }
}
