using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
   public class EfProjeRepository : GenericRepository<Proje>, IProjeDal
    {
        public List<Proje> GetListWithKategoriByUye(int id)
        {
            using (var c = new Context())
            {
                //return c.Maliyets.Include(x => x.Proje).ThenInclude(x=>x.Kategori).Where(x => x.projeID == id);
                return c.Projes.Include(x => x.Kategori).Where(x=>x.uyeID==id).ToList();
                 
            }
        }

        public List<Proje> GetListWithKategoriByProje(int id)
        {
            using (var c = new Context())
            {
                
                return c.Projes.Include(x => x.Kategori).Where(x => x.projeID == id).ToList();

            }
        }

        public List<Proje> GetListWithProjeByKategori(int id)
        {
            using (var c = new Context())
            {

                return c.Projes.Include(x => x.Kategori).Where(x => x.kategoriID == id).ToList();

            }
        }


        public List<Proje> GetWithU()
        {
            using (var c = new Context())
            {
                return c.Projes.Include(x => x.Uye).ToList();
            }
            
        }

        public List<Proje> GetListWithProjeByUye(int id)
        {
            using (var c = new Context())
            {

                return c.Projes.Include(x => x.Uye).Where(x => x.uyeID == id).ToList();

            }
        }
    }
}
