using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApplication.Models
{
    //business entity / Model Class - Always To be Written as Below
    public class Course
    {
        public string CourseName { get; set; }

        public int CourseId { get; set; }

        public int Fees { get; set; }
    }
}