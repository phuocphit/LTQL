using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTQL249.Models;

namespace LTQL249.Controllers
{
    public class HoaDonController : Controller
    {
        LTQLDbContext db = new LTQLDbContext();
        // GET: HoaDon
        public ActionResult Index()
        {
            return View(db.HoaDons.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(HoaDon hd)
        {
            if(ModelState.IsValid)
            {
                db.HoaDons.Add(hd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id)
        {
            HoaDon hd = db.HoaDons.Find(id);
            return View(hd);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HoaDon hd)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hd).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hd);
        }
        public ActionResult Delete(string id)
        {
            HoaDon hd = db.HoaDons.Find(id);
            return View(hd);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult ConfirmDelete(string id)
        {
            HoaDon hd = db.HoaDons.Find(id);
            db.HoaDons.Remove(hd);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}