using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Uye
    {
        [Key]
        public int uyeID { get; set; }

        public string uyeAdi { get; set; }

        public string uyeSoyadi { get; set; }

        public string parola { get; set; }

        public string email { get; set; }

        public string telNo { get; set; }

        public string resimURL { get; set; }


        public List<Takim> Takims { get; set; }
        public List<Yetenek> Yeteneks { get; set; }
        public List<Pozisyon> Pozisyons { get; set; }
        public List<Basvuru> Basvurus { get; set; }
        public List<Proje> Projes { get; set; }
    }
}
