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
    public class GereksinimListProje : ViewComponent
    {
        ProjeGereksinimManager pm = new ProjeGereksinimManager(new EfProjeGereksinimRepository());

        public IViewComponentResult Invoke(int id)
        {
            var  values =  pm.GetListWithGereksinimByProjeID(id);
            return View(values);
        }
    }
}
