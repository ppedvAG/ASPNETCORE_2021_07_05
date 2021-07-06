using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageKurs.Models
{
    /* Wo werden Models eingesetzt? 
     * 
     * -    Als Result-Class einer Service-Abfrage (Richtung UI) 
     * 
     * -    Code First Konzepten (EF Core) in Verbindung mit ASP.NET Core (Richtung Datenbank) 
     * 
     * 
     **/

    public class Movie
    {
        public int Id { get; set; }


        [DisplayName("Titel")]
        [Required] //Muss-Feld in der DB + in der UI 
        [MaxLength(20)]     //In DB wird nvarchar(20) angelegt
                                   //UI eine Input-Feld mit mx 20 Zeichen
        public string Title { get; set; }



        [DisplayName("Preis")]
        //[Range(0, 99.99)] //Geht richtung UI 
        //[RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Price { get; set; }
    }
}
