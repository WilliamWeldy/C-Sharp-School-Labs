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
  Lab #3
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
    }

    public class Person
    {
        //---Properties
        private string Fname;
        private string Lname;
        private string Email;
        private string Address;

        //Default Constructor
        public Person()
        {
            Fname = "";
            Lname = "";
            Email = "";
            Address = "";
        }
        //Other Constructor with args
        public Person(string f, string l, string e, string a)
        {
            Fname = f;
            Lname = l;
            Email = e;
            Address = a;
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
        public string getAddress()         { return Address; }
        public void   setAddress(string a) { Address = a; }

        //person's methods()
        public void Display()
        {
            Console.WriteLine("First Name: " + getFname());
            Console.WriteLine("Last Name: " + getLname());
            Console.WriteLine("Email Address: " + getEmail());
            Console.WriteLine("Street Address: " + getAddress());
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
        public int   getStudentID()      { return sid; }
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
        }
    }
}
