using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj2.ViewComponents
{
    public class RecourseProjectKategoriList : ViewComponent
    {
        ProjeManager pm = new ProjeManager(new EfProjeRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = pm.GetListWithKategoriByProjeID(id);
            return View(values);
        }
    }
}
