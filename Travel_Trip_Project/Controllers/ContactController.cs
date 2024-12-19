using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;

namespace Travel_Trip_Project.Controllers
{
    public class ContactController : Controller
    {
        private readonly TravelDbContext db = new TravelDbContext();
        public ActionResult Index()
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
                return RedirectToAction("Index");
            }

            // If the form data is invalid, stay on the same page and show errors
            return View("Index", contact);
        }
    }
}