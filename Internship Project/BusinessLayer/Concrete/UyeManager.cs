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
   public class UyeManager : IUyeService
    {
        IUyeDal _uyeDal;

        public UyeManager(IUyeDal uyeDal)
        {
            _uyeDal = uyeDal;
        }

        public Uye TGetById(int id)
        {
            return _uyeDal.GetById(id);
        }

        public List<Uye> GetList()
        {
            return _uyeDal.GetListAll();
        }

        public List<Uye> GetWithUyeID(int id)
        {
            return _uyeDal.GetWithUye(id);
        }

        public void TAdd(Uye t)
        {
            _uyeDal.Insert(t);
        }

        public void TDelete(Uye t)
        {
            _uyeDal.Delete(t);
        }

        public void TUpdate(Uye t)
        {
            _uyeDal.Update(t);
        }
    }
}
