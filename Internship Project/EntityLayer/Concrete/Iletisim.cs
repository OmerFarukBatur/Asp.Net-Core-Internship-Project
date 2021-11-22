using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Iletisim
    {
        [Key]
        public int iletisimID { get; set; }

        public string ad { get; set; }

        public string soyad { get; set; }

        public string email { get; set; }

        public string mesaj { get; set; }

        public string resimURL { get; set; }

        public Nullable<DateTime> olusTarihi { get; set; }
    }
}
