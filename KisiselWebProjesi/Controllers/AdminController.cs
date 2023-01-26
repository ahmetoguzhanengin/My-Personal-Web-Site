using KisiselWebProjesi.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }
        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.AnaSayfas.Find(id);

            return View("AnaSayfaGetir", ag);
        }
        public ActionResult AnaSayfaGuncelle(AnaSayfa x)
        {
            var ag = c.AnaSayfas.Find(x.id);
            ag.İsim = x.İsim;
            ag.profil = x.profil;
            ag.unvan = x.unvan;
            ag.aciklama = x.aciklama;
            ag.iletisim = x.iletisim;
            c.SaveChanges();

            return RedirectToAction("Index");

        }
        public ActionResult ikonListesi()
        {
            var deger = c.Icons.ToList();
            return View(deger);

        }
        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();

        }
        
        [HttpPost]
        public ActionResult YeniIkon(Icons p)
        {
            c.Icons.Add(p);
            c.SaveChanges();

            return RedirectToAction("ikonListesi");

        }
        
        public ActionResult ikonGetir(int id)
        {
           var ig = c.Icons.Find(id);

            return View("ikonGetir",ig);

        }
        public ActionResult ikonGuncelle(Icons x)
        {
            var ig = c.Icons.Find(x.id);
            ig.ikon = x.ikon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }
        public ActionResult ikonSil(int id)
        {
            var sl = c.Icons.Find(id);
            c.Icons.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }
    }
}