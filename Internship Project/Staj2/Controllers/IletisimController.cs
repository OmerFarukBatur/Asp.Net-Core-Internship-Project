using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj2.Controllers
{
    [AllowAnonymous]
    public class IletisimController : Controller
    {
        IletisimManager im = new IletisimManager(new EfIletisimRepository());

        [HttpGet]
        public IActionResult ProjectPost()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult ProjectPost(Iletisim i)
        {
            IletisimValidator iw = new IletisimValidator();
            ValidationResult results = iw.Validate(i);
            if (results.IsValid)
            {
                i.olusTarihi = DateTime.Parse(DateTime.Now.ToShortDateString());
                im.TAdd(i);
                return RedirectToAction("KullaniciIndex","Kullanici");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

    }
}
