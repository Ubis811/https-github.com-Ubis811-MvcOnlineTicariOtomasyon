﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class SatiHareket
    {
        [Key]
        public int Satisid { get; set; }
        //ürün
        //cari
        //Personel
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public Decimal Fiyat { get; set; }
        public Decimal Tutar { get; set; }

        public Urun Urun { get; set; }
        public Cariler Cariler { get; set; }
        public Personel Personel { get; set; }

    }
}