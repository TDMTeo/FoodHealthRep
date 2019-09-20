using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Food_Health_Modulo_3__B_4._3_.Models;

namespace Food_Health_Modulo_3__B_4._3_.Controllers
{
    public class DomiciliariosController : Controller
    {
        private Food_Health_Modulo_3__B_4_3_Context db = new Food_Health_Modulo_3__B_4_3_Context();

        // GET: Domiciliarios
        public ActionResult Index()
        {
            var domiciliarios = db.Domiciliarios.Include(d => d.Orden);
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
            ViewBag.idOrden = new SelectList(db.Ordens, "idOrden", "NombrePedido");
            return View();
        }

        // POST: Domiciliarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idDomiciliario,Nombres,Identificacion,Correo,FechaNacimiento,Telefono,EstadoOrden,idOrden")] Domiciliario domiciliario)
        {
            if (ModelState.IsValid)
            {
                db.Domiciliarios.Add(domiciliario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idOrden = new SelectList(db.Ordens, "idOrden", "NombrePedido", domiciliario.idOrden);
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
            ViewBag.idOrden = new SelectList(db.Ordens, "idOrden", "NombrePedido", domiciliario.idOrden);
            return View(domiciliario);
        }

        // POST: Domiciliarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idDomiciliario,Nombres,Identificacion,Correo,FechaNacimiento,Telefono,EstadoOrden,idOrden")] Domiciliario domiciliario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(domiciliario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idOrden = new SelectList(db.Ordens, "idOrden", "NombrePedido", domiciliario.idOrden);
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
