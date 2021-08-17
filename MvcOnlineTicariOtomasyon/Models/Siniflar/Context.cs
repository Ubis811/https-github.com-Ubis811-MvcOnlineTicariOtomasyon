﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Context: DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cariler> Carilers { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<FaturaKalem> FaturaKalems { get; set; }
        public DbSet<Faturalar> Faturalars { get; set; }
        public DbSet<Giderler> Giderlers { get; set; }
        public DbSet<Katagori> Katagoris { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<SatiHareket> SatiHarekets { get; set; }
        public DbSet<Urun> Uruns { get; set; }
    }
}