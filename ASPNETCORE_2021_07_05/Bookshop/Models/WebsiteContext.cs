using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageKurs.Models
{
    public class WebsiteContext
    {
        //prop + Tab + Tab
        public Version Version { get; set; }

        public int CopyrightYear { get; set; }

        public bool Approved { get; set; }

        public int TagsToShow { get; set; }
    }
}
