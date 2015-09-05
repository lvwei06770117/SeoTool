using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeoToolMvc.Models;
using SeoToolMvc.DAL;

namespace SeoToolMvc.Controllers
{
    public class OutSiteController : Controller
    {
        private OutSiteContext db = new OutSiteContext();

        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View(db.OutSites.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            OutSite outsite = db.OutSites.Find(id);
            if (outsite == null)
            {
                return HttpNotFound();
            }
            return View(outsite);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OutSite outsite)
        {
            if (ModelState.IsValid)
            {
                db.OutSites.Add(outsite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(outsite);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            OutSite outsite = db.OutSites.Find(id);
            if (outsite == null)
            {
                return HttpNotFound();
            }
            return View(outsite);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OutSite outsite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(outsite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(outsite);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            OutSite outsite = db.OutSites.Find(id);
            if (outsite == null)
            {
                return HttpNotFound();
            }
            return View(outsite);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OutSite outsite = db.OutSites.Find(id);
            db.OutSites.Remove(outsite);
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