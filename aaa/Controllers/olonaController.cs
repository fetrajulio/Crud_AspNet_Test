using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aaa.Models;

namespace aaa.Controllers
{ 
    public class olonaController : Controller
    {
        private OlonaDBContext db = new OlonaDBContext();

        //
        // GET: /olona/

        public ViewResult Index()
        {
            return View(db.Olonas.ToList());
        }

        //
        // GET: /olona/Details/5

        public ViewResult Details(int id)
        {
            Olona olona = db.Olonas.Find(id);
            return View(olona);
        }

        //
        // GET: /olona/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /olona/Create

        [HttpPost]
        public ActionResult Create(Olona olona)
        {
            if (ModelState.IsValid)
            {
                db.Olonas.Add(olona);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(olona);
        }
        
        //
        // GET: /olona/Edit/5
 
        public ActionResult Edit(int id)
        {
            Olona olona = db.Olonas.Find(id);
            return View(olona);
        }

        //
        // POST: /olona/Edit/5

        [HttpPost]
        public ActionResult Edit(Olona olona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(olona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(olona);
        }

        //
        // GET: /olona/Delete/5
 
        public ActionResult Delete(int id)
        {
            Olona olona = db.Olonas.Find(id);
            return View(olona);
        }

        //
        // POST: /olona/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Olona olona = db.Olonas.Find(id);
            db.Olonas.Remove(olona);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}