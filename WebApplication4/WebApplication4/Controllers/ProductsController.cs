using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class ProductsController : Controller
    {
        ProductsEntity ent = new ProductsEntity();
        // GET: Products
        public ActionResult ProductsTable()
        {
            return View(ent.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult AddProduct()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult AddProduct(Product pr)
        {
            try
            {
                if (pr.IsTaxable == false)
                {
                    pr.TaxAmout = 0;
                }
                
                
                ent.Products.Add(pr);
                ent.SaveChanges();
                return RedirectToAction("ProductsTable");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
