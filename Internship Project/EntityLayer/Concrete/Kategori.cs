using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kategori
    {
        [Key]

        public int kategoriID { get; set; }

        public string kategoriAdi { get; set; }

        public List<Proje> Projes { get; set; }
    }
}
