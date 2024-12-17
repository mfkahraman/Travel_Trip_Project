using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;

namespace Travel_Trip_Project.Controllers
{
    public class AdminController : Controller
    {
        TravelDbContext db = new TravelDbContext();
        public ActionResult Index()
        {
            var values = db.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(Blog model)
        {
            db.Blogs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}