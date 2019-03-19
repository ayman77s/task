using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RE.Models;

namespace RE.Controllers
{
    public class phonedeatilsController : Controller
    {
        private testEntities db = new testEntities();

        // GET: phonedeatils
        public ActionResult Index()
        {
            var phonedeatils = db.phonedeatils.Include(p => p.phone);
            return View(phonedeatils.ToList());
        }

        // GET: phonedeatils/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phonedeatil phonedeatil = db.phonedeatils.Find(id);
            if (phonedeatil == null)
            {
                return HttpNotFound();
            }
            return View(phonedeatil);
        }

        // GET: phonedeatils/Create
        public ActionResult Create()
        {
            ViewBag.phID = new SelectList(db.phones, "id", "name");
            return View();
        }

        // POST: phonedeatils/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "phonename,ram,cam,id,phID")] phonedeatil phonedeatil)
        {
            if (ModelState.IsValid)
            {
                db.phonedeatils.Add(phonedeatil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.phID = new SelectList(db.phones, "id", "name", phonedeatil.phID);
            return View(phonedeatil);
        }

        // GET: phonedeatils/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phonedeatil phonedeatil = db.phonedeatils.Find(id);
            if (phonedeatil == null)
            {
                return HttpNotFound();
            }
            ViewBag.phID = new SelectList(db.phones, "id", "name", phonedeatil.phID);
            return View(phonedeatil);
        }

        // POST: phonedeatils/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "phonename,ram,cam,id,phID")] phonedeatil phonedeatil)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phonedeatil).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.phID = new SelectList(db.phones, "id", "name", phonedeatil.phID);
            return View(phonedeatil);
        }

        // GET: phonedeatils/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phonedeatil phonedeatil = db.phonedeatils.Find(id);
            if (phonedeatil == null)
            {
                return HttpNotFound();
            }
            return View(phonedeatil);
        }

        // POST: phonedeatils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            phonedeatil phonedeatil = db.phonedeatils.Find(id);
            db.phonedeatils.Remove(phonedeatil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
