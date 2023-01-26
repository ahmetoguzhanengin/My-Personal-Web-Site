using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Classes
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public String kullaniciAdi{ get; set; }
        public String sifre{ get; set; }
    }
}