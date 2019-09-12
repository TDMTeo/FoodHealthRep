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
    public class DomiciliariosController : Controller
    {
        private FoodHealth_3Context db = new FoodHealth_3Context();

        // GET: Domiciliarios
        public ActionResult Index()
        {
            var domiciliarios = db.Domiciliarios.Include(d => d.TiposEstados);
            return View(domiciliarios.ToList());
        }

        // GET: Domiciliarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Domiciliario domiciliario = db.Domiciliarios.Find(id);
            if (domiciliario == null)
            {
                return HttpNotFound();
            }
            return View(domiciliario);
        }

        // GET: Domiciliarios/Create
        public ActionResult Create()
        {
            ViewBag.EstadosID = new SelectList(db.TiposEstados, "EstadosID", "Estado");
            return View();
        }

        // POST: Domiciliarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDomiciliario,Primer_Nombre,Segundo_Nombre,Edad,Año_Nacimiento,Correo,EstadosID")] Domiciliario domiciliario)
        {
            if (ModelState.IsValid)
            {
                db.Domiciliarios.Add(domiciliario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstadosID = new SelectList(db.TiposEstados, "EstadosID", "Estado", domiciliario.EstadosID);
            return View(domiciliario);
        }

        // GET: Domiciliarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Domiciliario domiciliario = db.Domiciliarios.Find(id);
            if (domiciliario == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstadosID = new SelectList(db.TiposEstados, "EstadosID", "Estado", domiciliario.EstadosID);
            return View(domiciliario);
        }

        // POST: Domiciliarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDomiciliario,Primer_Nombre,Segundo_Nombre,Edad,Año_Nacimiento,Correo,EstadosID")] Domiciliario domiciliario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(domiciliario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstadosID = new SelectList(db.TiposEstados, "EstadosID", "Estado", domiciliario.EstadosID);
            return View(domiciliario);
        }

        // GET: Domiciliarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Domiciliario domiciliario = db.Domiciliarios.Find(id);
            if (domiciliario == null)
            {
                return HttpNotFound();
            }
            return View(domiciliario);
        }

        // POST: Domiciliarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Domiciliario domiciliario = db.Domiciliarios.Find(id);
            db.Domiciliarios.Remove(domiciliario);
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
