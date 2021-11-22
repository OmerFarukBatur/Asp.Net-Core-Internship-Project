using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj2.ViewComponents
{
    public class UyeNameListBasvuru : ViewComponent
    {
        BasvuruManager bm = new BasvuruManager(new EfBasvuruRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = bm.GetListWithUyeByBasvuruID(id);
            return View(values);
        }
    
    }
}
