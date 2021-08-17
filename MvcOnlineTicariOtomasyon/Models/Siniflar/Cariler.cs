using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int Cariid { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public String CariAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public String CariSoyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public String CariSehir { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public String CariMail { get; set; }

        public ICollection<SatiHareket> SatiHarekets { get; set; }
    }
}