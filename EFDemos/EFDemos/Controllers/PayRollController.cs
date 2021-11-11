using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDemos.DAL;

namespace EFDemos.Controllers
{
    public class PayRollController : Controller
    {
        SPFTranningEntities objDbContext = new SPFTranningEntities();
        // GET: PayRoll
        public ActionResult Index()
        {
            return View(objDbContext.Departments.ToList());
        }
    }
}