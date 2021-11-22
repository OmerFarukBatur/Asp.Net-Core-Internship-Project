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
    public class TakimManager : ITakimService
    {
        ITakimDal _takimDal;

        public TakimManager(ITakimDal takimDal)
        {
            _takimDal = takimDal;
        }

        public List<Takim> GetList()
        {
            return _takimDal.GetListAll();
        }

        public List<Takim> GetListWithTakimByProjeID(int id)
        {
            return _takimDal.GetListWithTakimByProje(id);
        }

        public void TAdd(Takim t)
        {
            _takimDal.Insert(t);
        }

        public void TDelete(Takim t)
        {
            _takimDal.Delete(t);
        }

        public Takim TGetById(int id)
        {
            return _takimDal.GetById(id);
        }

        public void TUpdate(Takim t)
        {
            _takimDal.Update(t);
        }
    }
}
