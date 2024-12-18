using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;

namespace Travel_Trip_Project.Controllers
{
    [Authorize]
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

        public ActionResult DeleteBlog(int id)
        {
            var itemToDelete = db.Blogs.Find(id);
            db.Blogs.Remove(itemToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var itemToUpdate = db.Blogs.Find(id);
            return View(itemToUpdate);
        }

        [HttpPost]
        public ActionResult UpdateBlog(Blog model)
        {
            var itemToUpdate = db.Blogs.Find(model.ID);
            itemToUpdate.Title = model.Title;
            itemToUpdate.Description = model.Description;
            itemToUpdate.Date = model.Date;
            itemToUpdate.BlogImage = model.BlogImage;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}