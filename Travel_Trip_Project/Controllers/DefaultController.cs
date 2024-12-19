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
            var values = db.Hotels.Take(6).ToList();
            return PartialView(values);
        }

        public ActionResult About()
        {
            var degerler = db.Abouts.ToList();
            return View(degerler);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = TempData["Message"];
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(Contact contact)
        {
            if (ModelState.IsValid)
            {
                // Save the message to the database
                db.Contacts.Add(contact);
                db.SaveChanges();

                // Optionally, you could send an email or perform any other action
                // Send an email or do something else here, if needed

                // Set a success message using TempData
                TempData["Message"] = "Mesajınız başarıyla gönderildi!";
                return RedirectToAction("Contact");
            }

            // If the form data is invalid, stay on the same page and show errors
            return View("Index", contact);
        }

        public ActionResult Hotels()
        {
            var values = db.Hotels.ToList();
            return View(values);
        }

        public ActionResult Restaurants()
        {
            var values = db.Restaurants.ToList();
            return View(values);
        }
    }
}