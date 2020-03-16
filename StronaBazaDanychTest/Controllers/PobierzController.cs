using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace StronaBazaDanychTest.Controllers
{
    public class PobierzController : Controller
    {
        StronaCwiczenieBazaEntities db = new StronaCwiczenieBazaEntities();
        // GET: Pobierz
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Osoby o)
        {
            db.Osoby.Add(o);
            db.SaveChanges();
            return View("ListaOsob", db);
        }

        [HttpGet]
        public ActionResult Usun()
        {
            return View();


        }
        [HttpPost]
        public ActionResult Usun(Osoby o)
        {
            db.Osoby.Attach(o);
            db.Osoby.Remove(o);
            db.SaveChanges();
            return View("ListaOsob", db);


        }

        public ActionResult Pokaz(Osoby o)
        {
            ;
            return View(o);


        }

    }
}