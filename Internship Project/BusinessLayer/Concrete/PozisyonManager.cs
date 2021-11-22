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
    public class PozisyonManager : IPozisyonService
    {
        IPozisyonDal _pozisyonDal;

        public PozisyonManager(IPozisyonDal pozisyonDal)
        {
            _pozisyonDal = pozisyonDal;
        }

        public List<Pozisyon> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Pozisyon t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Pozisyon t)
        {
            throw new NotImplementedException();
        }

        public Pozisyon TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Pozisyon t)
        {
            throw new NotImplementedException();
        }
    }
}
