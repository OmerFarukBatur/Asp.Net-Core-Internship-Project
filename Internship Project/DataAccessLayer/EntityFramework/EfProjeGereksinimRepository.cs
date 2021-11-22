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
  public  class EfProjeGereksinimRepository : GenericRepository<ProjeGereksinim>, IProjeGereksinimDal
    {
        public List<ProjeGereksinim> GetWith()
        {
            throw new NotImplementedException();
        }

        public List<ProjeGereksinim> GetListWithGereksinimByProje(int id)
        {
            using (var c = new Context())
            {

                return c.ProjeGereksinims.Include(x => x.Proje).Where(x => x.projeID == id).ToList();

            }
        }
    }
}
