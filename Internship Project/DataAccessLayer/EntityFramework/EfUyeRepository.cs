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
   public class EfUyeRepository : GenericRepository<Uye>, IUyeDal
    {
        public List<Uye> GetWithUye(int id)
        {
            using (var c = new Context())
            {
                return c.Uyes.Include(x => x.Takims).ToList();
            }
        }

        
    }
}
