using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Travel_Trip_Project.Models.Siniflar;

namespace Travel_Trip_Project.Controllers
{
    [Authorize]
    public class AdminBlogController : Controller
    {
        private const int PageSize = 4;
        TravelDbContext db = new TravelDbContext();

        public ActionResult Index(int page = 1)
        {
            var values = db.Blogs.OrderByDescending(b => b.ID).ToPagedList(page, PageSize);
            return View(values);
        }

        public ActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(Blog blog, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var imagePath = SaveImage(file, "/wwwroot/images/blogs/");
                if (imagePath == null)
                {
                    ModelState.AddModelError("BlogImage", "Sadece .jpg, .jpeg, .png veya .gif dosyaları yükleyebilirsiniz.");
                    return View(blog);
                }
                blog.BlogImage = imagePath;
            }

            if (ModelState.IsValid)
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }

        public ActionResult DeleteBlog(int id)
        {
            var itemToDelete = db.Blogs.Find(id);
            if (itemToDelete != null)
            {
                try
                {
                    var oldImagePath = Server.MapPath(itemToDelete.BlogImage);
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }
                catch { }

                db.Blogs.Remove(itemToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var itemToUpdate = db.Blogs.Find(id);
            return View(itemToUpdate);
        }

        [HttpPost]
        public ActionResult UpdateBlog(Blog model, HttpPostedFileBase BlogImage)
        {
            var itemToUpdate = db.Blogs.Find(model.ID);
            if (itemToUpdate != null)
            {
                itemToUpdate.Title = model.Title;
                itemToUpdate.Description = model.Description;
                itemToUpdate.Date = model.Date;

                if (BlogImage != null && BlogImage.ContentLength > 0)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(itemToUpdate.BlogImage))
                        {
                            var oldImagePath = Server.MapPath(itemToUpdate.BlogImage);
                            if (System.IO.File.Exists(oldImagePath))
                            {
                                System.IO.File.Delete(oldImagePath);
                            }
                        }
                    }
                    catch { }

                    var imagePath = SaveImage(BlogImage, "/wwwroot/images/blogs/");
                    if (imagePath != null)
                    {
                        itemToUpdate.BlogImage = imagePath;
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
