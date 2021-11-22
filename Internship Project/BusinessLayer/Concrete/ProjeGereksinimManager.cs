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
    public class ProjeGereksinimManager : IProjeGereksinimService
    {
        IProjeGereksinimDal _projeGereksinimDal;

        public ProjeGereksinimManager(IProjeGereksinimDal projeGereksinimDal)
        {
            _projeGereksinimDal = projeGereksinimDal;
        }

        public List<ProjeGereksinim> GetList()
        {
            return _projeGereksinimDal.GetListAll();
        }

        public List<ProjeGereksinim> GetListWithGereksinimByProjeID(int id)
        {
            return _projeGereksinimDal.GetListWithGereksinimByProje(id);
        }

        public void TAdd(ProjeGereksinim t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ProjeGereksinim t)
        {
            throw new NotImplementedException();
        }

        public ProjeGereksinim TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ProjeGereksinim t)
        {
            throw new NotImplementedException();
        }
    }
}
