using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FoodHealth_3.Models;

namespace FoodHealth_3.Controllers
{
    public class TiposEstadosController : Controller
    {
        private FoodHealth_3Context db = new FoodHealth_3Context();

        // GET: TiposEstados
        public ActionResult Index()
        {
            return View(db.TiposEstados.ToList());
        }

        // GET: TiposEstados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiposEstados tiposEstados = db.TiposEstados.Find(id);
            if (tiposEstados == null)
            {
                return HttpNotFound();
            }
            return View(tiposEstados);
        }

        // GET: TiposEstados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposEstados/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EstadosID,Estado")] TiposEstados tiposEstados)
        {
            if (ModelState.IsValid)
            {
                db.TiposEstados.Add(tiposEstados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tiposEstados);
        }

        // GET: TiposEstados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiposEstados tiposEstados = db.TiposEstados.Find(id);
            if (tiposEstados == null)
            {
                return HttpNotFound();
            }
            return View(tiposEstados);
        }

        // POST: TiposEstados/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EstadosID,Estado")] TiposEstados tiposEstados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tiposEstados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tiposEstados);
        }

        // GET: TiposEstados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiposEstados tiposEstados = db.TiposEstados.Find(id);
            if (tiposEstados == null)
            {
                return HttpNotFound();
            }
            return View(tiposEstados);
        }

        // POST: TiposEstados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TiposEstados tiposEstados = db.TiposEstados.Find(id);
            db.TiposEstados.Remove(tiposEstados);
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
