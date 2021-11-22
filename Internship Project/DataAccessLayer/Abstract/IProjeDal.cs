using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProjeDal: IGenericDal<Proje>
    {
        List<Proje> GetWithU();
        List<Proje> GetListWithKategoriByUye(int id);
        List<Proje> GetListWithKategoriByProje(int id);
        List<Proje> GetListWithProjeByKategori(int id);
        public List<Proje> GetListWithProjeByUye(int id);
    }
}
