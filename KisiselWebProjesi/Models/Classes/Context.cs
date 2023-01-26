﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Classes
{
    public class Context: DbContext
    {
        public DbSet<Admin> Admins{ get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Icons> Icons { get; set; }
    }
}