
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FirstMVCApplication.DAL;

namespace FirstMVCApplication.Controllers
{
    public class SamplesController : Controller
    {
        private SPFTranningEntities db = new SPFTranningEntities();

        // GET: /Samples/DepartmentList
        public ActionResult DepartmentList()
        {
            return View(db.Departments.ToList());
        }
        public ActionResult ListEmployee(int? deptno)
        {
            //if (deptno == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Employee emp = db.Employees.Find(deptno);

            //if (emp == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(emp);

            var emp = db.Employees.Where(e => e.DeptNo == deptno);
            return View(emp);
        }

    }
}