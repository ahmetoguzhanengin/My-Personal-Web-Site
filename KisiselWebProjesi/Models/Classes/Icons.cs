using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Classes
{
    public class Icons
    {
        [Key]
        public int id { get; set; }
        public String ikon { get; set; }
        public String link { get; set; }

    }
}