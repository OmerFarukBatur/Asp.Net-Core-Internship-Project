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
    public class EfBasvuruRepository : GenericRepository<Basvuru>, IBasvuruDal
    {
        public List<Basvuru> GetWith()
        {
            using (var c =new Context())
            {
                return c.Basvurus.Include(x=>x.Proje).ToList();
            }
        }

        public List<Basvuru> GetListWithBasvuruByUye(int id)
        {
            using (var c = new Context())
            {

                return c.Basvurus.Include(x => x.Uye).Where(x => x.uyeID == id).ToList();

            }
        }

        public List<Basvuru> GetListWithBasvuruByProje(int id)
        {
            using (var c = new Context())
            {
                
                return c.Basvurus.Include(x => x.Proje).Where(x => x.projeID == id).ToList();

            }
        }

        public List<Basvuru> GetListWithUyeByBasvuru(int id)
        {
            using (var c = new Context())
            {

                return c.Basvurus.Include(x => x.Uye).Where(x => x.uyeID == id).ToList();

            }
        }
    }
}
