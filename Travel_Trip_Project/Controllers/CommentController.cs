using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;

namespace Travel_Trip_Project.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        private readonly TravelDbContext db = new TravelDbContext();
        public ActionResult Index()
        {
            var values = db.Comments.ToList();
            return View(values);
        }

        public ActionResult DeleteComment(int id)
        {
            var itemToDelete = db.Comments.Find(id);
            db.Comments.Remove(itemToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}