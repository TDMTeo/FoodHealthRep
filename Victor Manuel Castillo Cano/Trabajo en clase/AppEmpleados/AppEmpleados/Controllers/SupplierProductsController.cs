using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppEmpleados.Models;

namespace AppEmpleados.Controllers
{
    public class SupplierProductsController : Controller
    {
        private AppEmpleadosContext db = new AppEmpleadosContext();

        // GET: SupplierProducts
        public ActionResult Index()
        {
            var supplierProducts = db.SupplierProducts.Include(s => s.Product).Include(s => s.Supplier);
            return View(supplierProducts.ToList());
        }

        // GET: SupplierProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SupplierProduct supplierProduct = db.SupplierProducts.Find(id);
            if (supplierProduct == null)
            {
                return HttpNotFound();
            }
            return View(supplierProduct);
        }

        // GET: SupplierProducts/Create
        public ActionResult Create()
        {
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name");
            ViewBag.SupplierId = new SelectList(db.Suppliers, "SupplierId", "Name");
            return View();
        }

        // POST: SupplierProducts/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SupplierProductId,SupplierId,ProductId")] SupplierProduct supplierProduct)
        {
            if (ModelState.IsValid)
            {
                db.SupplierProducts.Add(supplierProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name", supplierProduct.ProductId);
            ViewBag.SupplierId = new SelectList(db.Suppliers, "SupplierId", "Name", supplierProduct.SupplierId);
            return View(supplierProduct);
        }

        // GET: SupplierProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SupplierProduct supplierProduct = db.SupplierProducts.Find(id);
            if (supplierProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name", supplierProduct.ProductId);
            ViewBag.SupplierId = new SelectList(db.Suppliers, "SupplierId", "Name", supplierProduct.SupplierId);
            return View(supplierProduct);
        }

        // POST: SupplierProducts/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SupplierProductId,SupplierId,ProductId")] SupplierProduct supplierProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(supplierProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name", supplierProduct.ProductId);
            ViewBag.SupplierId = new SelectList(db.Suppliers, "SupplierId", "Name", supplierProduct.SupplierId);
            return View(supplierProduct);
        }

        // GET: SupplierProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SupplierProduct supplierProduct = db.SupplierProducts.Find(id);
            if (supplierProduct == null)
            {
                return HttpNotFound();
            }
            return View(supplierProduct);
        }

        // POST: SupplierProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SupplierProduct supplierProduct = db.SupplierProducts.Find(id);
            db.SupplierProducts.Remove(supplierProduct);
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
