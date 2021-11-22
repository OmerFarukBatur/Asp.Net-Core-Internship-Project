using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Maliyet
    {
        [Key]
        public int maliyetID { get; set; }

        public string maliyetAdi { get; set; }

        public Nullable<int> maliyetFiyati { get; set; }
        
        public Nullable<int> projeID { get; set; }


        public Proje Proje { get; set; }
    }
}
