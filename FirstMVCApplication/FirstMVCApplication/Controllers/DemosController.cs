using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApplication.DAL;
using FirstMVCApplication.Models;

namespace FirstMVCApplication.Controllers
{
    public class DemosController : Controller
    {

        // GET: Demos

        //Action Methods for Views
        public ActionResult Courses()
        {
            ViewBag.Message = "Following are Courses";
            CoursesDAL objectCourseDal = new CoursesDAL();
            //Data Carrier (Dynamic Object)
            ViewBag.AllCourses = objectCourseDal.ListAllCourses();
            return View();
        }

        public ActionResult Products()
        {
            List<string> itemsList = new List<string>()
            {
               "lenovo laptop","Sata SDD HD","Head phones","Monitor"
            };
            //ist Dictonary and Stores In terms of Key value Pairs
            //Carry Data From Controller To View 
            ViewData["Items"] = itemsList;

            //returns view name ItemsList
            return View("ItemsList");
        }

        //Display Form 
        public ActionResult AddCourse()
        {
            ViewData["Message"] = "Welcome To ASP >NET MVC.";
            List<string> technologies = new List<string>();
            technologies.Add("Objective C");
            technologies.Add("Python");
            technologies.Add("Oracle");
            technologies.Add("Java");
            ViewBag.Technologies = new SelectList(technologies);
            return View();
        }

        //Process Form Request
        [HttpPost]
        public ActionResult AddCourse(FormCollection formControl)
        {
            int courseId = Convert.ToInt32(formControl["Course_ID"]);
            string courseName = formControl["Course_Name"];
            string fees = formControl["Fees"];
            string technology = formControl["Technologies"];
            string gender = formControl["Gender"];

            ViewBag.CourseID = courseId;
            ViewBag.CourseName = courseName;
            ViewBag.Fees = fees;
            ViewBag.Technologies = technology;
            ViewBag.Gender = gender;
            return View("DisplayCourse");
        }

        public ActionResult DisplayAllCourses()
        {

            List<Course> courseList = new List<Course>()
            {
                new Course(){CourseId=1,CourseName="AWS-Dev Tr", Fees=25000},
                new Course(){CourseId=2,CourseName="SalesForce", Fees=120000},
                new Course(){CourseId=3,CourseName="Python ML", Fees=35000},
                new Course(){CourseId=4,CourseName="Angular", Fees=20000},
            };
            return View(courseList);
        }

        public ActionResult FindAllCourses()
        {

            List<Course> courseList = new List<Course>()
            {
                new Course(){CourseId=1,CourseName="AWS-Dev Tr", Fees=25000},
                new Course(){CourseId=2,CourseName="SalesForce", Fees=120000},
                new Course(){CourseId=3,CourseName="Python ML", Fees=35000},
                new Course(){CourseId=4,CourseName="Angular", Fees=20000},
            };
            return View(courseList);
        }

        public ActionResult PerosnalDetails()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PerosnalDetails(FormCollection formCollection)
        {
            //ProfType

            ViewBag.ptitle = "Thank Yor the Details: ";
            ViewBag.title = " Your details as below";
            ViewBag.Name = "Firstname:   " + formCollection["FirstName"] + "  " + "LastName:  " + formCollection["LastName"];
            ViewBag.Gender = "Gender:  " + formCollection["Gender"];
            ViewBag.ProfType = "Type of profession --" + formCollection["ProfType"];
            return View("Thankyou");
        }

        public ActionResult PersonInformation()
        {
            string[] ownProperties = {"Bunglow","Car","Flat","Land","Two Wheeler"};
            string[] ownCards = { "Aadhar Card", "Voter Card", "Passport", "Driving" };
            ViewBag.OwnItems = ownProperties;
            ViewBag.OwnCards = ownCards;
            return View();
        }

        [HttpPost]
        public ActionResult PersonInformation(FormCollection formCollection)
        {
            string name = formCollection["fullName"];
            string contactNo = formCollection["contactNo"];
            string gender = formCollection["Gender"];
            string email = formCollection["email"];
            string member = formCollection["Members"];

            string ownItem = formCollection["OwnItem"];
            string[] properties = ownItem.Split(',');
            string ownCard = formCollection["OwnCard"];
            string[] cards = ownCard.Split(',');
            

            ViewBag.Message = "Thanks For Your Information.";
            ViewBag.name = name;
            ViewBag.email = email;
            ViewBag.gender = gender;
            ViewBag.contactNo = contactNo;
            ViewBag.Properties = properties;
            ViewBag.Cards = cards;
            ViewBag.memberInfo = member;
            return View("RegistrationSuccessful");
        }
    }
}