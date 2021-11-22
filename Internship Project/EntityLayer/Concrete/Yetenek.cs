using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yetenek
    {
        [Key]

        public int yetenekID { get; set; }

        public string yetenekAdi { get; set; }

        public string yetenekSeviyesi { get; set; }

        public Nullable<int> uyeID { get; set; }


        public Uye Uye { get; set; }
    }
}
