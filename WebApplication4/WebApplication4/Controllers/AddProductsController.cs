using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class AddProductsController : Controller
    {
        // GET: AddProducts
        public ActionResult AddProduct()
        {
            return View();
        }

        // GET: AddProducts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddProducts/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddProducts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddProducts/Edit/5
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

        // GET: AddProducts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddProducts/Delete/5
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
