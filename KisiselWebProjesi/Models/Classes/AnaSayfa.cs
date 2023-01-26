using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Classes
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public String profil { get; set; }
        public String İsim{ get; set; }
        public String unvan { get; set; }
        public String aciklama { get; set; }
        public String iletisim { get; set; }

    }
}