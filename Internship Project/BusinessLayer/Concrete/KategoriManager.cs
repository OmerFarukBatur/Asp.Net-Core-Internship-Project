using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KategoriManager : IKategoriService
    {
        IKategoriDal _kategoriDal;

        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public Kategori TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Kategori> GetKategoriListByProje(int id)
        {
            return _kategoriDal.GetListAll(x => x.kategoriID == id).ToList();
        }

        public List<Kategori> GetList()
        {
            return _kategoriDal.GetListAll();
        }

        public void TAdd(Kategori t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Kategori t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Kategori t)
        {
            throw new NotImplementedException();
        }
    }
}
