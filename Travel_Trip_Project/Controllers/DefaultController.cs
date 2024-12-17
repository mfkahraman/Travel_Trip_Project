using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;

namespace Travel_Trip_Project.Controllers
{
    public class DefaultController : Controller
    {
        TravelDbContext db = new TravelDbContext();
        
        // GET: Default
        public ActionResult Index()
        {
            var values = db.Blogs.ToList();
            return View(values);
        }

        public PartialViewResult ConBot()
        {
            var values = db.Blogs.OrderByDescending(x=> x.ID).Take(3).ToList();
            return PartialView(values);
        }

        public PartialViewResult Top10()
        {
            var values = db.Blogs.Take(10).ToList();
            return PartialView(values);
        }

        public PartialViewResult BestPlaces()
        {
            var values = db.Blogs.Take(6).ToList();
            return PartialView(values);
        }

    }
}