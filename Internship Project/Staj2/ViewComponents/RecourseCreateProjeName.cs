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
    
    public class RecourseCreateProjeName : ViewComponent
    {
        ProjeManager pm = new ProjeManager(new EfProjeRepository());

        public IViewComponentResult Invoke(int id)
        {
            List<SelectListItem> Value = (from x in pm.GetListWithProjeByKategoriID(id) select new SelectListItem { Text = x.projeAdi, Value = x.projeID.ToString() }).ToList();
            ViewBag.v = Value;
            return View();
        }
    }
}
