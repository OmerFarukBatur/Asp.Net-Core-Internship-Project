using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBasvuruDal: IGenericDal<Basvuru>
    {
        List<Basvuru> GetWith();
        List<Basvuru> GetListWithBasvuruByUye(int id);
        List<Basvuru> GetListWithBasvuruByProje(int id);
        List<Basvuru> GetListWithUyeByBasvuru(int id);
    }
}
