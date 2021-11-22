using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBasvuruService:IGenericService<Basvuru>
    {
        List<Basvuru> GetWithBasvuru();
        List<Basvuru> GetListWithBasvuruByUyeID(int id);
        List<Basvuru> GetListWithBasvuruByProjeID(int id);
        List<Basvuru> GetListWithUyeByBasvuruID(int id);
    }
}
