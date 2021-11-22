using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProjeGereksinimDal: IGenericDal<ProjeGereksinim>
    {
        List<ProjeGereksinim> GetWith();
        List<ProjeGereksinim> GetListWithGereksinimByProje(int id);
    }
}
