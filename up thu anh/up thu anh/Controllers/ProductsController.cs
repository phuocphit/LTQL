﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using up_thu_anh.Models;
using PagedList;

namespace up_thu_anh.Controllers
{
    public class ProductsController : Controller
    {
        private DBConnext db = new DBConnext();

        // GET: Products
        
        public ViewResult Index(int? page)
        {
            var pagesize = 10;
            var model = db.Products.ToList();
            int pageNumber = page ?? 1;
            return View(model.ToPagedList(pageNumber, pagesize));

        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,ProductName,Description,Status")] Product product, HttpPostedFileBase image)
        {
            if (image != null && image.ContentLength > 0)
            {
                product.Image = new byte[image.ContentLength]; // image stored in binary formate
                image.InputStream.Read(product.Image, 0, image.ContentLength);
                string fileName = System.IO.Path.GetFileName(image.FileName);
                string urlImage = Server.MapPath("/Image/" + fileName);
                image.SaveAs(urlImage);

                product.UrlImage = "/Image/" + fileName;
            }

            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,ProductName,Description,Status")] Product product, HttpPostedFileBase editImage)
        {
            if (ModelState.IsValid)
            {
                Product modifyProduct = db.Products.Find(product.ProductId);
                if (modifyProduct != null)
                {
                    if (editImage != null && editImage.ContentLength > 0)
                    {
                        modifyProduct.Image = new byte[editImage.ContentLength]; // image stored in binary formate
                        editImage.InputStream.Read(modifyProduct.Image, 0, editImage.ContentLength);
                        string fileName = System.IO.Path.GetFileName(editImage.FileName);
                        string urlImage = Server.MapPath("~/Image/" + fileName);
                        editImage.SaveAs(urlImage);

                        modifyProduct.UrlImage = "Image/" + fileName;
                    }
                }
                db.Entry(modifyProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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
        public ViewResult PageList(int? page)
        {
            var pagesize = 10;
            var model = db.Products.ToList();
            int pageNumber = page ?? 1;
            return View(model.ToPagedList(pageNumber, pagesize));

        }

    }
}
