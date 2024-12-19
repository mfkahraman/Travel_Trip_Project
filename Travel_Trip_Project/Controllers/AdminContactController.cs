using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace Travel_Trip_Project.Controllers
{
    public class AdminContactController : Controller
    {
        private const int PageSize = 4;
        TravelDbContext db = new TravelDbContext();

        public ActionResult Index(int page = 1)
        {
            var values = db.Contacts.OrderByDescending(b => b.ID).ToPagedList(page, PageSize);
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var itemToDelete = db.Contacts.Find(id);
            db.Contacts.Remove(itemToDelete);
            return RedirectToAction("Index");
        }
    }
}