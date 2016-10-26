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
            //{
                if (pr.IsTaxable == false)
                {
                    pr.TaxAmout = 0;
                }
                pr.CreatedDate = DateTime.Now;
                ent.Products.Add(pr);
                ent.SaveChanges();
                return RedirectToAction("ProductsTable");

            //}
            //else
            //{
            //    return View();
            //}

            //try
            //{
            //    if (pr.IsTaxable == false)
            //    {
            //        pr.TaxAmout = 0;
            //    }
            //    pr.ProductImage = data;
            //    ent.Products.Add(pr);
            //    ent.SaveChanges();
            //    return RedirectToAction("ProductsTable");
            //}
            //catch
            //{
            //    return View();
            //}
        }

    

        // GET: Products/Edit/5
        public ActionResult EditProduct(int id)
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

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult EditProduct(int id, HttpPostedFile uploadFile, Product pr)
        {
            try
            {
                // TODO: Add update logic here
                MemoryStream ms = new MemoryStream();
                uploadFile.InputStream.CopyTo(ms);
                byte[] data = ms.ToArray();
                pr.ProductImage = data;

                var proC = ent.ProductCategories.ToList();
                foreach (var x in proC)
                {
                    if (Request["ProductCategoryName"].ToString() == x.ProductCategoryName.ToString())
                    {
                        pr.ProductCategoryID = x.ProductCategoryID;
                        pr.CreatedBy = x.CreatedBy;
                        break;
                    }
                }

                //if (ModelState.IsValid)
                //{
                if (pr.IsTaxable == false)
                {
                    pr.TaxAmout = 0;
                }
                Product temp = ent.Products.Find(id);
                ent.Products.Remove(temp);
                ent.Products.Add(pr);
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
            return View();
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
