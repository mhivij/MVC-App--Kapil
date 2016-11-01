using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    
    public class HomeController : Controller
    {
        ProductsEntity ent = new ProductsEntity();
        // GET: Home
        public ActionResult HomePage(string category)
        {
            if (category != null)
            {
                /******* Old Logic ******/
                //int id = 0;
                //List<Product> li = new List<Product>();
                //var prod = ent.Products.ToList();
                //var proC = ent.ProductCategories.ToList();
                //foreach (var x in proC)
                //{
                //    if (x.ProductCategoryName == category)
                //    {
                //        id = x.ProductCategoryID;
                //        break;
                //    }
                //}

                //foreach (var y in prod)
                //{
                //    if (y.ProductCategoryID == id)
                //    {
                //        li.Add(y);
                //    }
                //}
                //return View(li.ToList());

                /******** New Logic *********/
                var z = (ent.ProductCategories.Where(r => r.ProductCategoryName == category).ToList()).First();
                return View(ent.Products.Where(r => r.ProductCategoryID == z.ProductCategoryID).ToList());
                
            }
            else
            {
                return View(ent.Products.ToList());
            }
        }
 
       
    }
}