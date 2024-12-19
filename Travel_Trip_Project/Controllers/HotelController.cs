using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;
using PagedList;
using PagedList.Mvc;

namespace Travel_Trip_Project.Controllers
{
    public class HotelController : Controller
    {
        private readonly TravelDbContext db = new TravelDbContext();

        public ActionResult Index(int page = 1)
        {
            var values = db.Hotels.ToList().ToPagedList(page, 4); ;
            return View(values);
        }

        public ActionResult AddHotel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHotel(Hotel hotel, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                // Dosya uzantısını al
                string fileExtension = Path.GetExtension(file.FileName).ToLower();

                // Geçerli dosya türlerini kontrol et
                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif")
                {
                    // Dosya adını benzersiz yapmak için GUID kullan
                    string fileName = Guid.NewGuid() + fileExtension;

                    // Dosya yolu
                    string path = Path.Combine(Server.MapPath("~/wwwroot/images/hotels"), fileName);

                    // Dosyayı kaydet
                    file.SaveAs(path);

                    // Hotel modeline görsel yolunu ekle
                    hotel.ImageUrl = "/wwwroot/images/hotels/" + fileName;
                }
                else
                {
                    ModelState.AddModelError("ImageUrl", "Sadece .jpg, .jpeg, .png veya .gif dosyaları yükleyebilirsiniz.");
                    return View(hotel);
                }
            }

            if (ModelState.IsValid)
            {
                // Hotel'i veritabanına kaydet
                db.Hotels.Add(hotel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hotel);
        }


        public ActionResult UpdateHotel(int id)
        {
            var hotel = db.Hotels.Find(id);
            if (hotel == null)
            {
                return HttpNotFound();
            }
            return View(hotel);
        }

        [HttpPost]
        public ActionResult UpdateHotel(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hotel).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hotel);
        }

        public ActionResult DeleteHotel(int id)
        {
            var hotel = db.Hotels.Find(id);
            if (hotel == null)
            {
                return HttpNotFound();
            }
            db.Hotels.Remove(hotel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
