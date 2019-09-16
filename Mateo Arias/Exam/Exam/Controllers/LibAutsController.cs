using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Exam.Models;

namespace Exam.Controllers
{
    public class LibAutsController : Controller
    {
        private ExamContext db = new ExamContext();

        // GET: LibAuts
        public ActionResult Index()
        {
            return View(db.LibAuts.ToList());
        }

        // GET: LibAuts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibAut libAut = db.LibAuts.Find(id);
            if (libAut == null)
            {
                return HttpNotFound();
            }
            return View(libAut);
        }

        // GET: LibAuts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibAuts/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDAutor,IDLibro")] LibAut libAut)
        {
            if (ModelState.IsValid)
            {
                db.LibAuts.Add(libAut);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(libAut);
        }

        // GET: LibAuts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibAut libAut = db.LibAuts.Find(id);
            if (libAut == null)
            {
                return HttpNotFound();
            }
            return View(libAut);
        }

        // POST: LibAuts/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDAutor,IDLibro")] LibAut libAut)
        {
            if (ModelState.IsValid)
            {
                db.Entry(libAut).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(libAut);
        }

        // GET: LibAuts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LibAut libAut = db.LibAuts.Find(id);
            if (libAut == null)
            {
                return HttpNotFound();
            }
            return View(libAut);
        }

        // POST: LibAuts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LibAut libAut = db.LibAuts.Find(id);
            db.LibAuts.Remove(libAut);
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
