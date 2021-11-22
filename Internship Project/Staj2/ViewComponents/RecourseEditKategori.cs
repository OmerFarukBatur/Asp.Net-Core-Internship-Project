using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj2.ViewComponents
{
    public class RecourseEditKategori : ViewComponent
    {
        ProjeManager pm = new ProjeManager(new EfProjeRepository());
        

        public IViewComponentResult Invoke(int id)
        {
            var values = pm.GetListWithKategoriByProjeID(id);
            List<SelectListItem> categoriyValue = (from x in pm.GetListWithKategoriByProjeID(id) select new SelectListItem { Text = x.Kategori.kategoriAdi, Value = x.kategoriID.ToString() }).ToList();
            ViewBag.cv = categoriyValue;
            return View();
        }

    }
}
