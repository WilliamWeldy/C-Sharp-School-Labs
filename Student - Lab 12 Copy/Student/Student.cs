using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************
  William Weldy
  Lab #12
*****************************************************/

namespace Student
{
    class Student : Person
    {
        private string _id;
        private string _major;
        private string _gpa;

        public Student()
        {
            ID = "0";
            Major = " ";
            GPA = "0.0";
        }
        public Student(string nameValue, string idValue, string phoneValue,string emailValue, string addressValue,string majorValue, string gpaValue)
        {
            ID = idValue;
            Major = majorValue;
            GPA = gpaValue;
        }

        public string ID
        {
            get { return _id; }
            set { _id = ""; }
        }

        public string Major
        {
            get { return _major; }
            set { _major = ""; }
        }

        public string GPA
        {
            get { return _gpa; }
            set { _gpa = ""; }
        }

        public void DisplayStudent()
        {
            DisplayPerson();
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Major: " + Major);
            Console.WriteLine("GPA: " + GPA);
        }
    }
}
