using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj2.ViewComponents
{
    public class MaliyetListProject : ViewComponent
    {
        MaliyetManager mm = new MaliyetManager(new EfMaliyetRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = mm.GetWithMaliyet(id);            
            return View(values);
        }
    }
}
