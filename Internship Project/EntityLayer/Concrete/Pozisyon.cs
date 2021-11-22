using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Pozisyon
    {
        [Key]
        public int pozisyonID { get; set; }

        public string pozisyonAdi { get; set; }

        public string pozisyonSeviyesi { get; set; }

        public Nullable<int> projeID { get; set; }

        public Nullable<int> uyeID { get; set; }



        public Proje Proje { get; set; }
        public Uye Uye { get; set; }
        
    }
}
