using FW_Food_Health_Modulo2.Context;
using FW_Food_Health_Modulo2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FW_Food_Health_Modulo2.Controllers
{
    public class DomiciliarioController : Controller
    {
        private FH_Modulo3_Context db = new FH_Modulo3_Context();
        // GET: Domiciliario
        public ActionResult Index()
        {
            return View(db.ClDomiciliario.ToList());
        }

        // GET: Domiciliario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Domi = db.ClDomiciliario.Find(id);
            if (Domi == null)
            {
                return HttpNotFound();
            }
            return View(Domi);
        }

        // GET: Domiciliario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Domiciliario/Create
        [HttpPost]
        public ActionResult Create(Domiciliario domi)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.ClDomiciliario.Add(domi);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(domi);

            }
            catch
            {
                return View(domi);
            }
        }

        // GET: Domiciliario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = db.ClDomiciliario.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Domiciliario/Edit/5
        [HttpPost]
        public ActionResult Edit(Domiciliario domi)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    db.Entry(domi).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(domi);
            }
            catch
            {
                return View(domi);
            }
        }

        // GET: Domiciliario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = db.ClDomiciliario.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Domiciliario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Domiciliario domi)
        {
            try
            {
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    domi = db.ClDomiciliario.Find(id);
                    if (domi == null)
                    {
                        return HttpNotFound();
                    }
                    db.ClDomiciliario.Remove(domi);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(domi);
            }
            catch
            {
                return View();
            }
        }
    }
}
