using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProjeGereksinim
    {
        [Key]
        public int gereksinimID { get; set; }

        public string gereksinimAdi { get; set; }

        public string gereksinimSeviyesi { get; set; }

        public Nullable<int> projeID { get; set; }


        public Proje Proje { get; set; }
    }
}
