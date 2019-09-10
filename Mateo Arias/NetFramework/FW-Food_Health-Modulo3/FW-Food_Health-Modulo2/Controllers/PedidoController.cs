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
    public class PedidoController : Controller
    {
        private FH_Modulo2_Context db = new FH_Modulo2_Context();
        // GET: Pedido
        public ActionResult Index()
        {
            return View(db.ClPedido.ToList());
        }

        // GET: Pedido/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Domi = db.ClPedido.Find(id);
            if (Domi == null)
            {
                return HttpNotFound();
            }
            return View(Domi);
        }

        // GET: Pedido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pedido/Create
        [HttpPost]
        public ActionResult Create(Pedido pedido)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.ClPedido.Add(pedido);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(pedido);

            }
            catch
            {
                return View(pedido);
            }
        }

        // GET: Pedido/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = db.ClPedido.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Pedido/Edit/5
        [HttpPost]
        public ActionResult Edit(Pedido pedido)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    db.Entry(pedido).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(pedido);
            }
            catch
            {
                return View(pedido);
            }
        }

        // GET: Pedido/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = db.ClPedido.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Pedido/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,Pedido pedido)
        {
            try
            {
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    pedido = db.ClPedido.Find(id);
                    if (pedido == null)
                    {
                        return HttpNotFound();
                    }
                    db.ClPedido.Remove(pedido);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(pedido);
            }
            catch
            {
                return View();
            }
        }
    }
}
