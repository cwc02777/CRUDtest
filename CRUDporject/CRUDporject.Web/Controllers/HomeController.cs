using CRUDproject.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CRUDporject.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1();
        public ActionResult Index()
        {
            return View(db.UserProfile.ToList());
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Name,Gender,Birthday")] UserProfile userProfile)
        {
            if (ModelState.IsValid)
            {
                
                db.UserProfile.Add(userProfile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userProfile);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Name,Gender,Birthday")] UserProfile userProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userProfile);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            UserProfile userProfile = db.UserProfile.Find(id);
            db.UserProfile.Remove(userProfile);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}