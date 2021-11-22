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
   public class ProjeManager:IProjeService
    {
        IProjeDal _projeDal;

        public ProjeManager(IProjeDal projeDal)
        {
            _projeDal = projeDal;
        }

        public Proje TGetById(int id)
        {
            return _projeDal.GetById(id);
        }

        public List<Proje> GetList()
        {
            return _projeDal.GetListAll();
        }

        public void TAdd(Proje t)
        {
            _projeDal.Insert(t);
        }

        public void TDelete(Proje t)
        {
            _projeDal.Delete(t);
        }

        public void TUpdate(Proje t)
        {
            _projeDal.Update(t);
        }

        public List<Proje>  GetProjeListByUye(int id) 
        {
            return _projeDal.GetListAll(x => x.uyeID == id).ToList();
        }

        //public List<Proje> GetProjeListByKategori(int id)
        //{
        //    return _projeDal.GetListAll(x => x.projeID == id).ToList();
        //}

        public List<Proje> GetWithProje()
        {
            return _projeDal.GetWithU();
        }

        public List<Proje> GetListWithKategoriByUyeID(int id)
        {
            return _projeDal.GetListWithKategoriByUye(id);
        }

        public List<Proje> GetListWithKategoriByProjeID(int id)
        {
            return _projeDal.GetListWithKategoriByProje(id);
        }

        public List<Proje> GetListWithProjeByKategoriID(int id)
        {
            return _projeDal.GetListWithProjeByKategori(id);
        }

        public List<Proje> GetListWithProjeByUyeID(int id)
        {
            return _projeDal.GetListWithProjeByUye(id);
        }
    }
}
