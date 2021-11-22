using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj2.ViewComponents
{
    public class SearcKategoriList : ViewComponent
    {
        KategoriManager km = new KategoriManager(new EfKategoriRepository());

        public IViewComponentResult Invoke()
        {
            var values = km.GetList().Distinct();
            return View(values);
        }
    }
}
