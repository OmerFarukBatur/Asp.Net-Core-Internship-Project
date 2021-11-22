using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Staj2.Controllers
{
    [AllowAnonymous]
    public class LogInController : Controller
    {
        public IActionResult KullaniciLogIn()
        {

            return View();
        }


        [HttpPost]
        
        public async Task<IActionResult> KullaniciLogIn(Uye u)
        {

            Context c = new Context();
            var datavalues = c.Uyes.FirstOrDefault(x => x.email == u.email && x.parola == u.parola);
            if (datavalues!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,u.email)
                };
                var userIdentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("KullaniciAdmin", "Admin");
            }
            else
            {
                return View();
            }

            //Context c = new Context();
            //var datavalue = c.Uyes.FirstOrDefault(x => x.email == u.email && x.parola == u.parola);
            //if (datavalue != null)
            //{
            //    HttpContext.Session.SetString("email", u.email);
            //    return RedirectToAction("KullaniciAdmin", "Admin");
            //}
            //else
            //{
            //    return View();
            //}
        }
    }
}
