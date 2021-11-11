using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstMVCApplication.Models;

namespace FirstMVCApplication.DAL
{

    //class That Deals With Data -  Using In Memory Collection as Data repository
    //and Model Class - Course 
    public class CoursesDAL
    {
        public List<Course> coursesList = new List<Course>()
        {
            new Course(){CourseId = 1,CourseName = "AWS",Fees = 2500},
            new Course(){CourseId = 2,CourseName = "React",Fees = 2400},
            new Course(){CourseId = 3,CourseName = "JavaScript",Fees = 2700},
            new Course(){CourseId = 4,CourseName = "Cloud",Fees = 2300}
        };

        public List<Course> ListAllCourses()
        {
            return this.coursesList;
        }
    }
}