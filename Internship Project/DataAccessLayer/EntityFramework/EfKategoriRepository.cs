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
    public class EfKategoriRepository : GenericRepository<Kategori>, IKategoriDal
    {
        public List<Kategori> GetWith()
        {
            using (var c = new Context())
            {
                return c.Kategoris.Include(x => x.kategoriID).ToList();
            }
        }
    }
}
