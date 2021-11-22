using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Proje
    {
        [Key]
        public int projeID { get; set; }

        public string projeAdi { get; set; }

        public string projeDetaylari { get; set; }

        public string projeDurumu { get; set; }

        public string resimURL { get; set; }

        public Nullable<DateTime> olusTarihi { get; set; }

        public Nullable<int> uyeID { get; set; }

        public Nullable<int> kategoriID { get; set; }


        public Kategori Kategori { get; set; }
        public Uye Uye { get; set; }
        public List<ProjeGereksinim> ProjeGereksinims { get; set; }
        public List<Pozisyon> Pozisyons { get; set; }
        public List<Takim> Takims { get; set; }
        public List<Maliyet> Maliyets { get; set; }        
        public List<Basvuru> Basvurus { get; set; }
    }
}
