using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IProjeService:IGenericService<Proje>
    {
        List<Proje> GetWithProje();
        List<Proje> GetListWithKategoriByUyeID(int id);
        List<Proje> GetListWithKategoriByProjeID(int id);
        List<Proje> GetProjeListByUye(int id);
        List<Proje> GetListWithProjeByKategoriID(int id);
        List<Proje> GetListWithProjeByUyeID(int id);
    }
}
