using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using WebApplication4.Models;
using System.Text.RegularExpressions;


namespace WebApplication4.Controllers
{
    public class CustomerController : Controller
    {
        private Models.Training_Orders_Engine_SandboxEntities ent = new Models.Training_Orders_Engine_SandboxEntities();

        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult GetData()
        {                
            return View(ent.Customers.ToList());
        }        
        public ActionResult InsertData()
        {          
            return View();
        }

        [HttpPost]
        public ActionResult InsertData(Customer cust)
        {
            if (!ModelState.IsValid)
            {
                return View("InsertData");
            }            
                ent.Customers.Add(cust);
                ent.SaveChanges();
                return RedirectToAction("GetData");   
        }
        
        public ActionResult Delete(int id)
        {           
            Customer cust = ent.Customers.Find(id);
            if(cust == null)
            {
                return HttpNotFound();
            }
            return View(cust);
        }

        [HttpPost][ActionName("Delete")]
        public ActionResult DeleteData(int id)
        {
            Customer cust = ent.Customers.Find(id);
            ent.Customers.Remove(cust);
            ent.SaveChanges();
            return RedirectToAction("GetData");
        }
        public ActionResult Edit(int id)
        {
            Customer cust = ent.Customers.Find(id);
            return View(cust);
        }
        [HttpPost][ActionName("Edit")]
        public ActionResult EditData(int id, Customer cust)
        {
            Customer tempCust = ent.Customers.Find(id);
            ent.Customers.Remove(tempCust);
            ent.Customers.Add(cust);
            ent.SaveChanges();
            return RedirectToAction("GetData");
        }

        



    }
}