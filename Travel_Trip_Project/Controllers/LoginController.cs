using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Travel_Trip_Project.Models.Siniflar;

namespace Travel_Trip_Project.Controllers
{
    public class LoginController : Controller
    {
        private readonly TravelDbContext db = new TravelDbContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin model)
        {
            var value = db.Admins.FirstOrDefault(x=> x.User == model.User && x.Password == model.Password);
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(value.User, false);
                Session["Kullanici"] = value.User.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}