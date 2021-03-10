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
  Lab #4
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
        private void personButton_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();
            Section sp1 = new Section();
            p1.add(sp1);
            p1.Display();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            s1.Display();
        }

        private void InstructorButton_Click(object sender, EventArgs e)
        {
            Instructor I1 = new Instructor();
            I1.Display();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            Schedule ss = new Schedule();
            ss.addSection(new Section()); ss.addSection(new Section()); //2 sections added
            ss.display();
        }
    }

    public class Person
    {
        //---Properties
        private string Fname;
        private string Lname;
        private string Email;
        private Address addr = new Address();
        private Schedule ps = new Schedule();

        //Default Constructor
        public Person()
        {
            Fname = "";
            Lname = "";
            Email = "";
        }
        //Other Constructor with args
        public Person(string f, string l, Address a, string e)
        {
            Fname = f;
            Lname = l;
            addr = a;
            Email = e;
        }

        //---Accessors and Mutators
             //First Name
        public string getFname()         { return Fname; }
        public void   setFname(string f) { Fname = f; }
             //Last Name
        public string getLname()         { return Lname; }
        public void   setLname(string l) { Lname = l; }
            //Email Address
        public string getEmail()         { return Email; }
        public void   setEmail(string e) { Email = e; }
            //Street Address
        public Address getAddress()          { return addr; }
        public void    setAddress(Address a) { addr = a; }

        //person's methods()
        public void add(Section s)
        {
            Section sp1 = new Section();
            ps.addSection(sp1);
        }
        public void Display()
        {
            Console.WriteLine("First Name: " + getFname());
            Console.WriteLine("Last Name: " + getLname());
            Console.WriteLine("Email Address: " + getEmail());
            addr.display();
            ps.display();
        }
    }

    public class Student : Person
    {
        //---Properties
        private int sid;
        private decimal GPA;
 
        //Default Constructor
        public Student() : base()
        {
            sid = 0;
            GPA = 0.0m;
        }
        //Other Constructor with args
        public Student(int id, decimal GradePointAverage) : base()
        {
            sid = id;
            GPA = GradePointAverage;
        }

        //---Accessors and Mutators
            //StudentID
        public int  getStudentID()       { return sid; }
        public void setStudentID(int id) { sid = id; }
            //GPA
        public decimal getGPA()           { return sid; }
        public void    setGPA(decimal id) { sid = id; }

        //Students' methods()
        public void Display()
        {
            base.Display();
            Console.WriteLine("Student's ID #: " + getStudentID());
            Console.WriteLine("Grade Point Average: " + getGPA());
            Section ss1 = new Section();
            base.add(ss1);
        }
    }

    public class Instructor : Person
    {
        //---Properties
        private int Iid;
        private string Office;

        //Default Constructor
        public Instructor() : base()
        {
            Iid = 0;
            Office = "A0000";
        }
        //Other Constructor with args
        public Instructor(int id, string room) : base()
        {
            Iid = id;
            Office = room;
        }

        //---Accessors and Mutators
             //InstructorID
        public int  getInstructorID()       { return Iid; }
        public void setInstructorID(int id) { Iid = id; }
             //Office #
        public string getOffice()         { return Office; }
        public void   setOffice(string o) { Office = o; }

        //Instructors' methods()
        public void Display()
        {
            base.Display();
            Console.WriteLine("Instructor's ID: " + getInstructorID());
            Console.WriteLine("Office: " + getOffice());
            Section si1 = new Section();
            base.add(si1);
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
         public int  getZip() { return Zip; }
         public void setZip(int z) { Zip = z; }
            //Street
         public string getStreet()         { return Street; }
         public void   setStreet(string s) { Street = s; }

          //---Address methods()
         public void display()
         {
              Console.WriteLine("Street Address: " + getStreet() + ", " + getCity() + " " + getState() + ", " + getZip());
         }
    }


    public class Schedule
    {
         //---Properties
         public int count = 0;
         public Section[] secArr = new Section[10];

         public Schedule()
         {
         }

         public void addSection(Section s)
         {
         secArr[count] = s;
         count++;
         }

         public void display() {
            Section s1 = new Section();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("----------\nSECTION " + (i+1) + "\n----------");
                s1.display();
            }
            Console.WriteLine("----------");
        }
    }

        public class Section
        {
        //---Properties
        private int CRN;
            private string CourseID = "";
        private string timeDay = "";
        private string roomNo = "";
            private int Iid;

        Instructor i = new Instructor();

        //Default Constructor
        public Section()
        {
            CRN = 30000;
            getCourseID();
            timeDay = "∅";
            roomNo = "A0000";
            i.getInstructorID();
        }
        //Other Constructor using args
        public Section(int courseReferenceNumber, string CourseNumber, string sectionTimeDay, string roomNumber, int InstructorID)
        {
            CRN = courseReferenceNumber;
            CourseID = CourseNumber;
            timeDay = sectionTimeDay;
            roomNo = roomNumber;
            Iid = InstructorID;
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
        public string getCourseID()           { return CourseID; }
        public void   setCourseID(string cid) { CourseID = cid; }

        //---Section methods()
        public void display()
          {
            Console.WriteLine("CRN: " + getCRN());
            Console.WriteLine("Course ID: " + getCourseID());
            Console.WriteLine("Time and Day(s) of the week: " + getTimeDay());
            Console.WriteLine("Room #: " + getRoomNumber());
            Console.WriteLine("Instructor ID: " + i.getInstructorID());
        }
    }
}
