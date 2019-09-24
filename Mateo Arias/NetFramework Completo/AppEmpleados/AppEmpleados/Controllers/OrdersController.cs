using AppEmpleados.Models;
using AppEmpleados.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppEmpleados.Controllers
{
    public class OrdersController : Controller
    {
        AppEmpleadosContext db = new AppEmpleadosContext();
        // GET: Orders
        public ActionResult NewOrder()
        {
            var orderView = new OrderView();
            orderView.Customer = new Customer();
            orderView.Products = new List<ProductOrder>();

            var list = db.Customers.ToList();
            list = list.OrderBy(c => c.FullName).ToList();
            ViewBag.customerID = new SelectList(list, "CustomerID", "FullName");
            
            return View(orderView);
        }
        [HttpPost]
        public ActionResult NewOrder(OrderView orderView)
        {
            var list = db.Customers.ToList();
            list = list.OrderBy(c => c.FullName).ToList();
            ViewBag.customerID = new SelectList(list, "CustomerID", "FullName");

            return View(orderView);
        }

        public ActionResult AddProduct(ProductOrder productOrder)
        {
            return View(productOrder);
        }
    }
}