using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class OrderHistoryController : Controller
    {
        private OrderHistoryEntities ent = new OrderHistoryEntities();
        // GET: OrderHistory
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderHistory/Details/5
        public ActionResult Details()
        {
            return View(ent.OrderHistories.ToList());
        }

        // GET: OrderHistory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderHistory/Create
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

        // GET: OrderHistory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderHistory/Edit/5
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

        // GET: OrderHistory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderHistory/Delete/5
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
