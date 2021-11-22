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
    public class RegisterController : Controller
    {
        UyeManager uyeLogin = new UyeManager(new EfUyeRepository());

        [HttpGet]
        public IActionResult KullaniciSignUp()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult KullaniciSignUp(Uye u)
        {
            UyeValidator uv = new UyeValidator();
            ValidationResult results = uv.Validate(u);

            if (results.IsValid) {
                uyeLogin.TAdd(u);
                return RedirectToAction("KullaniciLogIn", "Kullanici");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
