using System;
using System.Collections.Generic;
using System.IO;
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
       
            List<SelectListItem> li = new List<SelectListItem>();
            var proC = ent.ProductCategories.ToList();
            foreach (var x in proC)
            {
                li.Add(new SelectListItem { Text = x.ProductCategoryName.ToString(), Value = x.ProductCategoryName.ToString() });
         
            }
            ViewData["ProductCategoryName"] = li;
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult AddProduct(Product pr, HttpPostedFileBase uploadFile)
        {
            MemoryStream ms = new MemoryStream();
            uploadFile.InputStream.CopyTo(ms);
            byte[] data = ms.ToArray();
            pr.ProductImage = data;

            var proC = ent.ProductCategories.ToList();
            foreach (var x in proC)
            {
                if( Request["ProductCategoryName"].ToString() == x.ProductCategoryName.ToString())
                {
                    pr.ProductCategoryID = x.ProductCategoryID;
                    pr.CreatedBy = x.CreatedBy;
                    break;
                }
            }

            //if (ModelState.IsValid)
            
                if (pr.IsTaxable == false)
                {
                    pr.TaxAmout = 0;
                }
                pr.CreatedDate = DateTime.Now;
                ent.Products.Add(pr);
                ent.SaveChanges();
                return RedirectToAction("ProductsTable");           
        }


        public ActionResult ProductDescription(int id)
        {
            Product pr = ent.Products.Find(id);
            return View(pr);
        }
        
        //public void FilterResult()
        //{
        //    string str = "Electronics";
        //    int id=0;
        //    List<Product> li = new List<Product>();
        //    var prod = ent.Products.ToList();
        //    var proC = ent.ProductCategories.ToList();
        //    foreach(var x in proC)
        //    {
        //        if (x.ProductCategoryName == str)
        //        {
        //            id = x.ProductCategoryID;
        //            break;
        //        }
        //    }
        //    foreach(var y  in prod)
        //    {
        //        if(y.ProductCategoryID==id)
        //        {
        //            li.Add(y);
        //        }
        //    }
        //    HomeController hc = new HomeController();
        //    hc.HomePage(li, "dummy");
        //}
    

        // GET: Products/Edit/5
        public ActionResult EditProduct(int id)
        {
            Product prod = ent.Products.Find(id);
            List<SelectListItem> li = new List<SelectListItem>();
            var proC = ent.ProductCategories.ToList();
            foreach (var x in proC)
            {
                li.Add(new SelectListItem { Text = x.ProductCategoryName.ToString(), Value = x.ProductCategoryName.ToString() });

            }
            ViewData["ProductCategoryName"] = li;
            return View(prod);
        }



        //public partial class Products : Product
        //{
        //  public int id { get; set; }
        //  public HttpPostedFileBase uploadFile { get; set;}

        //}

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult EditProduct(int id, Product products, HttpPostedFileBase uploadFile)
        {
            try
            {
                // TODO: Add update logic here
                MemoryStream ms = new MemoryStream();
                uploadFile.InputStream.CopyTo(ms);
                byte[] data = ms.ToArray();
                products.ProductImage = data;

                var proC = ent.ProductCategories.ToList();
                foreach (var x in proC)
                {
                    if (Request["ProductCategoryName"].ToString() == x.ProductCategoryName.ToString())
                    {
                        products.ProductCategoryID = x.ProductCategoryID;
                        products.CreatedBy = x.CreatedBy;
                        break;
                    }
                }

                //if (ModelState.IsValid)
                
                if (products.IsTaxable == false)
                {
                    products.TaxAmout = 0;
                }
                Product temp = ent.Products.Find(id);
                UpdateModel(temp);
                ent.SaveChanges();
                return RedirectToAction("ProductsTable");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult DeleteProduct(int id)
        {
            Product pr = ent.Products.Find(id);
            return View(pr);
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult DeleteProduct(int id, FormCollection collection)
        {
            try
            {
                Product pr = ent.Products.Find(id);
                ent.Products.Remove(pr);
                ent.SaveChanges();
                return RedirectToAction("ProductsTable");
            }
            catch
            {
                return View();
            }
        }
    }
}
