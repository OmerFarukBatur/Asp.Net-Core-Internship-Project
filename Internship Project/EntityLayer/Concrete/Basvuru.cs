﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Basvuru
    {
        [Key]
        public int basvuruID { get; set; }

        public string projeAdi { get; set; }

        public string basvuruKabulDurumu { get; set; }

        public Nullable<DateTime> olusTarihi { get; set; }
  
        public Nullable<int> projeID { get; set; }
      
        public Nullable<int> uyeID { get; set; }

        public Nullable<int> teklif { get; set; }

        public string pozisyonAdi { get; set; }

        public string pozisyonSeviyesi { get; set; }

        public Proje Proje { get; set; }
        public Uye Uye { get; set; }
    }
}
