using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace Travel_Trip_Project.Controllers
{
    public class AdminRestaurantController : Controller
    {
        private const int PageSize = 4;
        TravelDbContext db = new TravelDbContext();

        public ActionResult Index(int page = 1)
        {
            var values = db.Restaurants.OrderByDescending(b => b.ID).ToPagedList(page, PageSize);
            return View(values);
        }

        public ActionResult AddRestaurant()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRestaurant(Restaurant model, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var imagePath = SaveImage(file, "/wwwroot/images/restaurants/");
                if (imagePath == null)
                {
                    ModelState.AddModelError("BlogImage", "Sadece .jpg, .jpeg, .png veya .gif dosyaları yükleyebilirsiniz.");
                    return View(model);
                }
                model.ImageUrl = imagePath;
            }

            if (ModelState.IsValid)
            {
                db.Restaurants.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult DeleteRestaurant(int id)
        {
            var itemToDelete = db.Restaurants.Find(id);
            if (itemToDelete != null)
            {
                try
                {
                    var oldImagePath = Server.MapPath(itemToDelete.ImageUrl);
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }
                catch { }

                db.Restaurants.Remove(itemToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateRestaurant(int id)
        {
            var itemToUpdate = db.Restaurants.Find(id);
            return View(itemToUpdate);
        }

        [HttpPost]
        public ActionResult UpdateRestaurant(Restaurant model, HttpPostedFileBase ImageUrl)
        {
            var itemToUpdate = db.Restaurants.Find(model.ID);
            if (itemToUpdate != null)
            {
                itemToUpdate.Name = model.Name;
                itemToUpdate.Description = model.Description;

                if (ImageUrl != null && ImageUrl.ContentLength > 0)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(itemToUpdate.ImageUrl))
                        {
                            var oldImagePath = Server.MapPath(itemToUpdate.ImageUrl);
                            if (System.IO.File.Exists(oldImagePath))
                            {
                                System.IO.File.Delete(oldImagePath);
                            }
                        }
                    }
                    catch { }

                    var imagePath = SaveImage(ImageUrl, "/wwwroot/images/blogs/");
                    if (imagePath != null)
                    {
                        itemToUpdate.ImageUrl = imagePath;
                    }
                }

                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        private string SaveImage(HttpPostedFileBase file, string folderPath)
        {
            string fileExtension = Path.GetExtension(file.FileName).ToLower();
            if (fileExtension != ".jpg" && fileExtension != ".jpeg" && fileExtension != ".png" && fileExtension != ".gif")
            {
                return null;
            }

            string fileName = Guid.NewGuid() + fileExtension;
            string serverFolderPath = Server.MapPath(folderPath);
            if (!Directory.Exists(serverFolderPath))
            {
                Directory.CreateDirectory(serverFolderPath);
            }
            string path = Path.Combine(serverFolderPath, fileName);
            file.SaveAs(path);

            return folderPath + fileName;
        }
    }
}
