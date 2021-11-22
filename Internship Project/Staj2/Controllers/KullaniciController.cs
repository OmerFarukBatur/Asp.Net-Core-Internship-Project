using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
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
    public class KullaniciController : Controller
    {
        BasvuruManager bm = new BasvuruManager(new EfBasvuruRepository());
        ProjeManager pm = new ProjeManager(new EfProjeRepository());
        public IActionResult KullaniciIndex()
        {
            var values = pm.GetList();
            return View(values);
            
        }

        public IActionResult KullaniciSearchJobIndex()
        {
            var values = bm.GetWithBasvuru();
            return View(values);
        }

        [HttpGet]
        public IActionResult PasswordUpdate()
        {
            
                return View();
            
        }


        [HttpPost]
        public IActionResult PasswordUpdate(Uye u)
        {
            UyeManager um = new UyeManager(new EfUyeRepository());
            Context c = new Context();
            var datavalues = c.Uyes.FirstOrDefault(x => x.email == u.email);

            UyeValidator pw = new UyeValidator();
            ValidationResult results = pw.Validate(u);
            if (results.IsValid)
            {

                if (datavalues != null)
                {
                    u.resimURL = datavalues.resimURL;
                    u.telNo = datavalues.telNo;
                    u.uyeAdi = datavalues.uyeAdi;
                    u.uyeSoyadi = datavalues.uyeSoyadi;
                    u.email = datavalues.email;
                    um.TUpdate(u);
                    return RedirectToAction("KullaniciLogIn", "LogIn");
                }
                else
                {
                    return View();
                }
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
