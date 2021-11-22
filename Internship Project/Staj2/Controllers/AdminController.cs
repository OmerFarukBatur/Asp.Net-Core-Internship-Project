using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj2.Controllers
{
    public class AdminController : Controller
    {
        ProjeManager pm = new ProjeManager(new EfProjeRepository());
        BasvuruManager bm = new BasvuruManager(new EfBasvuruRepository());
        UyeManager um = new UyeManager(new EfUyeRepository());
        TakimManager tm = new TakimManager(new EfTakimRepository());

        Context c = new Context();
        

        public IActionResult KullaniciAdmin()
        {
            var kullaniciemail=User.Identity.Name;
            var kullaniciID= c.Uyes.Where(x => x.email == kullaniciemail).Select(y => y.uyeID).FirstOrDefault();

            return View();
        }


        public IActionResult KullaniciProjectView()
        {
            var kullaniciemail = User.Identity.Name;
            var kullaniciID = c.Uyes.Where(x => x.email == kullaniciemail).Select(y => y.uyeID).FirstOrDefault();
            var values = pm.GetListWithKategoriByUyeID(kullaniciID);
            //var deger = values[0].projeID; //MaliyetManager mm = new MaliyetManager(new EfMaliyetRepository()); //var a = mm.GetWithMaliyet(deger); //ViewBag.b = a;
            return View(values.ToList());
        }

        public IActionResult KullaniciProjectDelete(int id)
        {
            var valueDelete = pm.TGetById(id);
            pm.TDelete(valueDelete);
            return RedirectToAction("Admin","KullaniciProjectView");
        }


        [HttpGet]
        public IActionResult KullaniciProjectEdit(int id)
        {
            KategoriManager km = new KategoriManager(new EfKategoriRepository());
            ProjeGereksinimManager pgm = new ProjeGereksinimManager(new EfProjeGereksinimRepository());
            List<SelectListItem> categoriyValue = (from x in km.GetList() select new SelectListItem { Text = x.kategoriAdi, Value = x.kategoriID.ToString() }).ToList();
            List<SelectListItem> gereksinimAdi = (from x in pgm.GetList() select new SelectListItem { Text = x.gereksinimAdi, Value = x.gereksinimID.ToString() }).ToList();
            List<SelectListItem> gereksinimSeviyesi = (from x in pgm.GetList() select new SelectListItem { Text = x.gereksinimSeviyesi, Value = x.gereksinimID.ToString() }).ToList();
            ViewBag.gvA = gereksinimAdi;
            ViewBag.gvS = gereksinimSeviyesi;
            ViewBag.cv = categoriyValue;
            //var kategorivalues = pm.GetListWithKategoriByProjeID(id); //ViewBag.kpID = kategorivalues; //var gereksinimvalues = pgm.GetListWithGereksinimByProjeID(id); //ViewBag.gpID = gereksinimvalues;
            
            var projectValue = pm.TGetById(id);
            return View(projectValue);
            
        }

        [HttpPost]
        public IActionResult KullaniciProjectEdit(Proje p)
        {
            KategoriManager km = new KategoriManager(new EfKategoriRepository());
            ProjeGereksinimManager pgm = new ProjeGereksinimManager(new EfProjeGereksinimRepository());
            List<SelectListItem> categoriyValue = (from x in km.GetList() select new SelectListItem { Text = x.kategoriAdi, Value = x.kategoriID.ToString() }).ToList();
            List<SelectListItem> gereksinimAdi = (from x in pgm.GetList() select new SelectListItem { Text = x.gereksinimAdi, Value = x.gereksinimID.ToString() }).ToList();
            List<SelectListItem> gereksinimSeviyesi = (from x in pgm.GetList() select new SelectListItem { Text = x.gereksinimSeviyesi, Value = x.gereksinimID.ToString() }).ToList();
            ViewBag.gvA = gereksinimAdi;
            ViewBag.gvS = gereksinimSeviyesi;
            ViewBag.cv = categoriyValue;

            //var values = pgm.GetListWithGereksinimByProjeID(p.projeID);
            

            ProjectValidator pw = new ProjectValidator();
            ValidationResult results = pw.Validate(p);
            if (results.IsValid)
            {
                pm.TUpdate(p);
                return RedirectToAction("KullaniciProjectView");
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

        [HttpGet]
        public IActionResult KullaniciProjectCreate()
        {
            KategoriManager km = new KategoriManager(new EfKategoriRepository());
            List<SelectListItem> categoriyValue = (from x in km.GetList() select new SelectListItem { Text = x.kategoriAdi, Value = x.kategoriID.ToString() }).ToList();
            ViewBag.cv = categoriyValue;
            return View();
            
        }
        [HttpPost]
        public IActionResult KullaniciProjectCreate(Proje p)
        {
            KategoriManager km = new KategoriManager(new EfKategoriRepository());
            List<SelectListItem> categoriyValue = (from x in km.GetList() select new SelectListItem { Text = x.kategoriAdi, Value = x.kategoriID.ToString() }).ToList();
            ViewBag.cv = categoriyValue;

            ProjectValidator pw = new ProjectValidator();
            ValidationResult results = pw.Validate(p);
            if (results.IsValid)
            {
                pm.TAdd(p);
                return RedirectToAction("KullaniciAdmin");
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

        [HttpGet]
        public IActionResult KullaniciAdminSetting()
        {
            var kullaniciemail = User.Identity.Name;
            var kullaniciID = c.Uyes.Where(x => x.email == kullaniciemail).Select(y => y.uyeID).FirstOrDefault();

            var uyevalues = um.TGetById(kullaniciID);

            return View(uyevalues);
        }
        [HttpPost]
        public IActionResult KullaniciAdminSetting(Uye u)
        {
            UyeValidator uw = new UyeValidator();
            ValidationResult results = uw.Validate(u);
            if (results.IsValid)
            {
                um.TUpdate(u);
                return RedirectToAction("KullaniciAdmin");
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

        [HttpGet]
        public IActionResult KullaniciRecourseCreate()
        {
            KategoriManager km = new KategoriManager(new EfKategoriRepository());
            List<SelectListItem> categoriyValue = (from x in km.GetList() select new SelectListItem 
            { Text = x.kategoriAdi, Value = x.kategoriID.ToString() }).ToList();
            ViewBag.cv = categoriyValue;            
            return View();
        }

        [HttpPost]
        public IActionResult KullaniciRecourseCreate(Basvuru b)
        {
            
            return RedirectToAction();
        }

        public IActionResult KullaniciRecourseView()
        {
            var kullaniciemail = User.Identity.Name;
            var kullaniciID = c.Uyes.Where(x => x.email == kullaniciemail).Select(y => y.uyeID).FirstOrDefault();
            var values = bm.GetListWithBasvuruByUyeID(kullaniciID);
            return View(values);
        }

        public IActionResult KullaniciRecourseDelete(int id)
        {
            var valueDelete = bm.TGetById(id);
            bm.TDelete(valueDelete);
            return RedirectToAction("KullaniciRecourseView");
        }

        [HttpGet]
        public IActionResult KullaniciRecourseEdit(int id)
        {
            var pozisyonName= (from x in bm.GetList() select new SelectListItem 
            { Text = x.pozisyonAdi, Value = x.basvuruID.ToString() }).Distinct().ToList();
            var pozisyonLevel = (from x in bm.GetList() select new SelectListItem 
            { Text = x.pozisyonSeviyesi, Value = x.basvuruID.ToString() }).ToList();
            
            ViewBag.pN = pozisyonName;
            ViewBag.pL = pozisyonLevel;

            var basvurutValue = bm.TGetById(id);
            return View(basvurutValue);
        }

        [HttpPost]
        public IActionResult KullaniciRecourseEdit(Basvuru basvuru)
        {

            return RedirectToAction();
        }

        public IActionResult KullaniciTeamCreate()
        {
            
            return View();
        }

        public IActionResult KullaniciTeamView()
        {
            var kullaniciemail = User.Identity.Name;
            var kullaniciID = c.Uyes.Where(x => x.email == kullaniciemail).Select(y => y.uyeID).FirstOrDefault();
            var projevalues = pm.GetListWithProjeByUyeID(kullaniciID);
            var degisim = projevalues.ToList();
            var takimvalues = tm.GetListWithTakimByProjeID(degisim[0].projeID);

            return View(takimvalues);
        }

        public IActionResult KullaniciTeamDelete(int id)
        {
            var valueDelete = tm.TGetById(id);
            tm.TDelete(valueDelete);
            return RedirectToAction("KullaniciRecourseView");
        }

        public IActionResult KullaniciTeamEdit()
        {
            
            return View();
        }

        public IActionResult RecourseView()
        {
            var kullaniciemail = User.Identity.Name;
            var kullaniciID = c.Uyes.Where(x => x.email == kullaniciemail).Select(y => y.uyeID).FirstOrDefault();
            var projevalues = pm.GetListWithProjeByUyeID(kullaniciID);
            var degisim = projevalues.ToList();
            var basvuruvalues = bm.GetListWithBasvuruByProjeID(degisim[0].projeID);
            return View(basvuruvalues);
        }
    }
}
