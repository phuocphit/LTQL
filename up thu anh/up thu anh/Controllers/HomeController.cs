using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace up_thu_anh.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        private DBConnext db = new DBConnext();
        //phan trang ra nhieu vi du list 10 trang nho cai pagedlist 5,18m
        //using PagedList
        public ViewResult PageList(int? page)
        {
            var pagesize = 10;
            var model = db.Products.ToList();
            int pageNumber = page ?? 1;
            return View(model.ToPagedList(pageNumber, pagesize));

        }
    }

    public class DBConnext : Models.DBConnext
    {
        internal object ToList()
        {
            throw new NotImplementedException();
        }
    }
}