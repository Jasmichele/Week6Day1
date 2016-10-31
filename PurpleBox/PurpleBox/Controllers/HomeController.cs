using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PurpleBox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult OverDue(int? id)
        {
        MovieRentalEntities1 db = new MovieRentalEntities1();
            List<string> overDue = new List<string>();

            var allMovies = from m in db.RentalRecords
                            where m.DueDate < DateTime.Today
                            select m;


            return View();
        }
    }
}