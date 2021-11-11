using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosOOPs
{
    //public class Student
    //{
    //    //private members of teh class
    //    private string fullName;
    //    private string gender;
    //    private string qualification;

    //    //default constructor
    //    public Student()
    //    {
    //        this.fullName = "Abc";
    //        this.gender = "Male";
    //        this.qualification = "MS CSC";
    //    }

    //    //parametric constructor
    //    public Student( string fullName, string gender, string qualification)
    //    {
    //        this.fullName = fullName;
    //        this.gender = gender;
    //        this.qualification = qualification;
    //    }
    //    //Properites-getters(read) and setters(assign a value)
    //    public string FullName
    //    {
    //        get { return this.fullName; } //getter
    //        set { this.fullName = value; } //setter

    //    }

    //    public string Gender
    //    {
    //        get { return this.gender; }
    //        set { this.gender = value; }

    //    }
    //    public string Qualification
    //    {
    //        get { return this.qualification; }
    //        set { this.qualification = value; }

    //    }


    //    public string DisplayStudentDetails()
    //    {
    //         return studentDetails = string.Format("Full Name- {0}  , Gender - {1}  Post Graduation - {2} ", this.FullName, this.Gender, this.qualification);

    //       
    //    }

    //}


    public class Student
    {
        //private members of teh class
        private string fullName;
        private string gender;
        private string qualification;

        //default constructor
        public Student()
        {
            this.fullName = "Abc";
            this.gender = "Male";
            this.qualification = "MS CSC";
        }

        //parametric constructor
        public Student(string fullName, string gender, string qualification)
        {
            this.fullName = fullName;
            this.gender = gender;
            this.qualification = qualification;
        }
        //Auto implemenetd Properites-getters(read) and setters(assign a value)
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }

        //to Display the Student Details in teh desired string format
        //String representation of object using String.format method
        public string DisplayStudentDetails()
        {
            string studentDetails = string.Format("Full Name- {0}  , Gender - {1}  Post Graduation - {2} ", this.FullName, this.Gender, this.Qualification);
            return studentDetails;
        }

        // /to Display the Student Details in teh desired string format
        // the above code can be also achievd as below

        //ToString() belongs to the class object
        public override string ToString()
        {
            return string.Format("Full Name- {0}  , Gender - {1}  Post Graduation - {2} ", this.FullName, this.Gender, this.Qualification);
        }
    }
}
