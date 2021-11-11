using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApplication.DAL;


namespace FirstMVCApplication.Controllers
{
    public class SportsController : Controller
    {
        // GET: Sports
        public ActionResult Sports()
        {
            List<string> sportsList = new List<string>()
           { "Badminton","Cricket","Football","Swimming","Tennis"};

            ViewBag.Sports = sportsList;

            return View();
        }

        public ActionResult MatcheSchedules()
        {
            SportsDAL obj = new SportsDAL();
            ViewBag.MatchSchedules = obj.ListAllMatchSchedules();

            return View();
        }
    }
}