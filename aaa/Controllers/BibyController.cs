using aaa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aaa.Controllers
{
    public class BibyController : Controller
    {
        //
        // GET: /Biby/
        private BibyDBContext db = new BibyDBContext();
        public ViewResult Index()
        {
            return View(db.Bibys.ToList());
        }

        public ViewResult insc() {
            return View();
        }


        [HttpPost]
        public ActionResult insc(Biby b) {
            if (ModelState.IsValid) {
                db.Bibys.Add(b);
                db.SaveChanges();
                return RedirectToAction("index");
            }

            return View();
        }

        
        public ActionResult Delete(int id) {
            Biby b = db.Bibys.Find(id);
            db.Bibys.Remove(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult modif(int id) {
            Biby b = db.Bibys.Find(id);
            return View(b);
        }

        [HttpPost]
        public ActionResult modif(Biby b) {
            if (ModelState.IsValid) {
                db.Entry(b).State =EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(b);
        }
    }
}
