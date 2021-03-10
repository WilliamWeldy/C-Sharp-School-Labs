using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    class Student
    {
        private string _name;
        private string _id;
        private string _phoneNumber;
        private string _EMail;
        private string _address;
        private string _major;
        private string _gpa;

        public string Name
        {
            get { return _name; }
            set { _name = ""; }
        }

        public string ID
        {
            get { return _id; }
            set { _id = ""; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = ""; }
        }

        public string EMail
        {
            get { return _EMail; }
            set { _EMail = ""; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = ""; }
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

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Phone #: " + PhoneNumber);
            Console.WriteLine("E-Mail Address: " + EMail);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Major: " + Major);
            Console.WriteLine("GPA: " + GPA);
        }
    }
}
