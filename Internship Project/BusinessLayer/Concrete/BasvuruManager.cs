using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BasvuruManager : IBasvuruService
    {
        IBasvuruDal _basvuruDal;

        public BasvuruManager(IBasvuruDal basvuruDal)
        {
            _basvuruDal = basvuruDal;
        }

        public Basvuru TGetById(int id)
        {
            return _basvuruDal.GetById(id);
        }

        public List<Basvuru> GetList()
        {
            return _basvuruDal.GetListAll();
        }

        public List<Basvuru> GetWithBasvuru()
        {
            return _basvuruDal.GetWith();
        }

        public void TAdd(Basvuru t)
        {
            _basvuruDal.Insert(t);
        }

        public void TDelete(Basvuru t)
        {
            _basvuruDal.Delete(t);
        }

        public void TUpdate(Basvuru t)
        {
            _basvuruDal.Update(t);
        }

        public List<Basvuru> GetListWithBasvuruByUyeID(int id)
        {
            return _basvuruDal.GetListWithBasvuruByUye(id);
        }

        public List<Basvuru> GetListWithBasvuruByProjeID(int id)
        {
            return _basvuruDal.GetListWithBasvuruByProje(id);
        }

        public List<Basvuru> GetListWithUyeByBasvuruID(int id)
        {
            return _basvuruDal.GetListWithUyeByBasvuru(id);
        }
    }
}
