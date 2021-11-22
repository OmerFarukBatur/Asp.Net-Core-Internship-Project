using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ITakimDal: IGenericDal<Takim>
    {
        List<Takim> GetWith();
        List<Takim> GetListWithTakimByProje(int id);
    }
}
