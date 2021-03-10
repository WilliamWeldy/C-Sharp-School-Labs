using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************
  William Weldy
  Lab #2
    CIST 2342: C# Programming II
*****************************************************/

namespace CsharpProgrammingII_StudentRegistrationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //---Buttons for testing classess
        private void addressButton_Click(object sender, EventArgs e)
        {
            Address a1 = new Address();
            a1.display();
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            Course c1 = new Course();
            c1.display();
        }

        private void sectionButton_Click(object sender, EventArgs e)
        {
            Section s1 = new Section();
            s1.display();
        }
    }


    public class Address
    {
        //---Properties
        private string Street = "";
        private string City = "";
        private string State = "";
        private int Zip;

        //Default Constructor
        public Address()
        {
            Street = "∅";
            City = "∅";
            State = "GA";
            Zip = 00000;
        }
        //Other Constructor with args
        public Address(string personState, string personCity, int zipCode, string personStreet)
        {
            State = personState;
            City = personCity;
            Zip = zipCode;
            Street = personStreet;
        }

        //---Accessors and Mutators
            //State
        public string getState()         { return State; }
        public void   setState(string s) { State = s; }
            //City
        public string getCity()         { return City; }
        public void   setCity(string c) { City = c; }
            //Zip
        public int  getZip()         { return Zip; }
        public void setZip(int z)    { Zip = z; }
            //Street
        public string getStreet()         { return Street; }
        public void   setStreet(string s) { Street = s; }

        //---Address methods()
        public void display()
        {
            Console.WriteLine("Person's address: " + getStreet() + ", " + getCity() + " " + getState() + ", " + getZip());
        }
    }


    public class Course
    {
        //---Properties
        private string CourseID = "";
        private string CourseName = "";
        private string Description = "";
        private int CreditHours;

        //Default Constructor
        public Course()
        {
            CourseID = "CIST 0000";
            CourseName = " ";
            Description = "N/A";
            CreditHours = 3;
        }
        //Other Constructor with args
        public Course(string id, string name, string desc, int hours)
        {
            CourseID = id;
            CourseName = name;
            Description = desc;
            CreditHours = hours;
        }


        //---Accessors and Mutators
            //CourseID
        public string getCourseID()           { return CourseID; }
        public void   setCourseID(string cid) { CourseID = cid; }
            //Course's Name
        public string getCourseName()          { return CourseName; }
        public void   setCourseName(string cn) { CourseName = cn; }
            //Description for the Course
        public string getDescription()            { return Description; }
        public void   setDescription(string desc) { Description = desc; }
            //Credit Hours for the Course
        public int  getCreditHours()        { return CreditHours; }
        public void setCreditHours(int hrs) { CreditHours = hrs; }

        //---Course methods()
        public void display()
        {
            Console.WriteLine("CourseID: " + getCourseID());
            Console.WriteLine("Course Name: " + getCourseName());
            Console.WriteLine("Course Description: " + getDescription());
            Console.WriteLine("Credit Hours: " + getCreditHours());
        }
    }


    public class Section
    {
        //---Properties
        private int CRN;
        private string CourseID = "";
        private string timeDay = "";
        private string roomNo = "";

        //Default Constructor
        public Section()
        {
            CRN = 30000;
            c.getCourseID();
            timeDay = "∅";
            roomNo = "A0000";
        }
        //Other Constructor using args
        public Section(int courseReferenceNumber, string CourseNumber, string sectionTimeDay, string roomNumber)
        {
            CRN = courseReferenceNumber;
            CourseID = CourseNumber;
            timeDay = sectionTimeDay;
            roomNo = roomNumber;
        }


        //---Accessors and Mutators
            //CRN
        public int  getCRN()                          { return CRN; }
        public void setCRN(int courseReferenceNumber) { CRN = courseReferenceNumber; }
            //TimeDays
        public string getTimeDay()                      { return timeDay; }
        public void   setTimeDay(string sectionTimeDay) { timeDay = sectionTimeDay; }
            //Room Number
        public string getRoomNumber()                  { return roomNo; }
        public void   setRoomNumber(string roomNumber) { roomNo = roomNumber; }
            //CourseID
        public string getCourseID()         { return CourseID; }
        public void setCourseID(string cid) { CourseID = cid; }

        //---Section methods()
        public void display()
        {
            Console.WriteLine("CRN: " + getCRN());
            Console.WriteLine("Course ID: " + c.getCourseID());
            Console.WriteLine("Time and Day(s) of the week: " + getTimeDay());
            Console.WriteLine("Room #: " + getRoomNumber());
        }
    }
}
