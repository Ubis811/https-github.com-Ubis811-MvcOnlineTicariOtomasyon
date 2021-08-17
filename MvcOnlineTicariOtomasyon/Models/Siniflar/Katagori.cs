using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Katagori
    {
        [Key]
        public int KatagoriID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KatagoriAd { get; set; }
        public ICollection<Urun> uruns { get; set; }
    }
}