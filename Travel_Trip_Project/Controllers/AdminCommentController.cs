using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Travel_Trip_Project.Models.Siniflar;
using PagedList;
using PagedList.Mvc;

namespace Travel_Trip_Project.Controllers
{
    [Authorize]
    public class AdminCommentController : Controller
    {
        private readonly TravelDbContext db = new TravelDbContext();
        public ActionResult Index(int page = 1)
        {
            var values = db.Comments.ToList().ToPagedList(page, 4);
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