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
    public class MaliyetManager : IMaliyetService
    {
        IMaliyetDal _maliyetDal;

        public MaliyetManager(IMaliyetDal maliyetDal)
        {
            _maliyetDal = maliyetDal;
        }

        public Maliyet TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Maliyet> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Maliyet> GetWithMaliyet(int id)
        {
            return _maliyetDal.GetWithM(id);
        }

        public void TAdd(Maliyet t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Maliyet t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Maliyet t)
        {
            throw new NotImplementedException();
        }

    }
}
