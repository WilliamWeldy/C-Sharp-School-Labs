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
  Lab #5
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
        private void courseButton_Click(object sender, EventArgs e)
        {
            /*SELECT
            Course c1 = new Course();
            c1.selectDB("CIST 1220");
            c1.display();*/

            /*INSERT
            Course c1 = new Course("CIST 1314", "Intro to Python", "xxxxxxx", 4);
            c1.insertDB();*/

            /*UPDATE
            Course c1 = new Course("CIST 1314");
            c1.selectDB("CIST 1314");
            c1.setCourseName("Python Programming");
            c1.setCreditHours(7);
            c1.updateDB();*/

            /*DELETE
            Course c1 = new Course();
            c1.selectDB("CIST 1313");
            c1.deleteDB();*/
        }

        private void sectionButton_Click(object sender, EventArgs e)
        {
            /*SELECT
            Section s1 = new Section();
            s1.selectDB(30101);
            s1.display();*/

            /*INSERT
            Section s1 = new Section(30138, "CIST 1328", "TW2-6pm", "F1138", 7);
            s1.insertDB();*/

            /*UPDATE
            Section s1 = new Section();
            s1.selectDB(30119);
            s1.setRoomNumber("F1147");
            s1.setTimeDay("TW3-7pm");
            s1.updateDB();*/

            /*DELETE
            Section s1 = new Section();
            s1.selectDB(30118);
            s1.deleteDB();*/
        }

        private void studentButton_Click(object sender, EventArgs e)
        {

            /*SELECT
            Student s1 = new Student();
            s1.selectDB(15);
            s1.Display();*/

            /*INSERT
            Student s1 = new Student(17,3.9);
            s1.setFname("William");
            s1.setLname("Weldy");
            s1.setEmail("Williamgweldy@hotmail.com");
            s1.insertDB();*/

            /*UPDATE
            Student s1 = new Student();
            s1.selectDB(4);
            s1.setEmail("williamupdated@hotmail.com");
            s1.updateDB();*/

            /*DELETE
            Student s1 = new Student();
            s1.selectDB(17);
            s1.deleteDB();*/
        }

        private void instructorButton_Click(object sender, EventArgs e)
        {

            /*SELECT
            Instructor i1 = new Instructor();
            i1.selectDB(1);
            i1.Display();*/

            /*INSERT
            Instructor i1 = new Instructor(7, "F1148");
            i1.setFname("William");
            i1.setLname("Weldy");
            i1.setEmail("Williamgweldy@hotmail.com");
            i1.insertDB();*/

            /*
            Instructor i1 = new Instructor();
            i1.selectDB(1);
            i1.setEmail("williamupdated@hotmail.com");
            i1.updateDB();*/

            /*DELETE
            Instructor i1 = new Instructor();
            i1.selectDB(7);
            i1.deleteDB();*/
        }
    }

    public class Person
    {
        //---Properties
        private string Fname;
        private string Lname;
        private string Email;
        public Address addr = new Address();
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
        public string getFname() { return Fname; }
        public void setFname(string f) { Fname = f; }
        //Last Name
        public string getLname() { return Lname; }
        public void setLname(string l) { Lname = l; }
        //Email Address
        public string getEmail() { return Email; }
        public void setEmail(string e) { Email = e; }
        //Street Address
        public Address getAddress() { return addr; }
        public void setAddress(Address a) { addr = a; }

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
            Console.WriteLine("Street Address: " + addr.getStreet() + "," + addr.getCity() + "," + addr.getState() + "," + addr.getZip());
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
        //Constructor accepting an arguement to look up the Student's ID
        public Student(int pk) : base()
        {
            selectDB(pk);
        }

        //---Accessors and Mutators
        //StudentID
        public int getStudentID() { return sid; }
        public void setStudentID(int id) { sid = id; }
        //GPA
        public decimal getGPA() { return GPA; }
        public void setGPA(decimal grade) { GPA = grade; }


        ////////*+* DATABASE SET UP *+*\\\\\\\\
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection OleDbConnection2;
            public string cmd;

        public void DBSetup()
        {
            OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbConnection2 = new System.Data.OleDb.OleDbConnection();

                OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
                OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
                OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;
                OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;

            OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" +
            "ocking Mode=1;Data Source=C:\\Users\\DefaultTheMighty\\source\\repos\\CsharpProgrammingII-StudentRegistrationSystem\\RegistrationMDB.mdb;J" +
            "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +
            "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
            "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
            "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
            "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
        }

        //Students' methods()
        public void selectDB(int id)
        {
            DBSetup();
            cmd = "SELECT * FROM Students WHERE ID = " + id;
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                sid = id;
                base.setFname(dr.GetValue(1) + "");
                base.setLname(dr.GetValue(2) + "");
                addr.setStreet(dr.GetValue(3) + "");
                addr.setCity(dr.GetValue(4) + "");
                addr.setState(dr.GetValue(5) + "");
                addr.setZip(Int32.Parse(dr.GetValue(6) + ""));
                setEmail(dr.GetValue(7) + "");
                setGPA(Decimal.Parse(dr.GetValue(8) + ""));
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
        public void insertDB()
        {
            DBSetup();
            cmd = "INSERT into Students VALUES(" + getStudentID() + "," +
                                              "" + "\"" + getFname() + "\"" + "," +
                                              "" + "\"" + getLname() + "\"" + "," +
                                              "" + "\"" + addr.getStreet() + "\"" + "," +
                                              "" + "\"" + addr.getCity() + "\"" + "," +
                                              "" + "\"" + addr.getState() + "\"" + "," +
                                              "" + addr.getZip() + "," +
                                              "" + "\"" + getEmail() + "\"" + "," +
                                              "" + getGPA() + ")";
            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data INSERTed");
                else Console.WriteLine("ERROR: Inserting Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
        public void updateDB()
        {
            DBSetup();
            cmd = "UPDATE Students SET FirstName = " + "\"" + getFname() + "\"" + "," +
                                           " LastName = " + "\"" + getLname() + "\"" + "," +
                                           " Street = " + "\"" + addr.getStreet() + "\"" + "," +
                                           " City = " + "\"" + addr.getCity() + "\"" + "," +
                                           " State = " + "\"" + addr.getState() + "\"" + "," +
                                           " Zip = " + addr.getZip() + "," +
                                           " EMail = " + "\"" + getEmail() + "\"" + "," +
                                           " GPA = " + getGPA() + " " + 
                                           "WHERE ID = " + getStudentID();
            OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data UPDATEd");
                else Console.WriteLine("ERROR: Updating Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
        public void deleteDB()
        {
            DBSetup();
            cmd = "DELETE from Students WHERE ID = " + getStudentID();
            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data DELETEd");
                else Console.WriteLine("ERROR: Deleting Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
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
            Iid = getInstructorID();
            Office = "A0000";
        }
        //Other Constructor with args
        public Instructor(int id, string room) : base()
        {
            Iid = id;
            Office = room;
        }
        //Constructor accepting an arguement to look up the Instructor's ID
        public Instructor(int pk)
        {
            selectDB(pk);
        }


        ////////*+* DATABASE SET UP *+*\\\\\\\\
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection OleDbConnection2;
            public string cmd;

        public void DBSetup()
        {
            OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbConnection2 = new System.Data.OleDb.OleDbConnection();

                OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
                OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
                OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;
                OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;

            OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" +
            "ocking Mode=1;Data Source=C:\\Users\\DefaultTheMighty\\source\\repos\\CsharpProgrammingII-StudentRegistrationSystem\\RegistrationMDB.mdb;J" +
            "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +
            "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
            "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
            "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
            "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
        }

        //---Accessors and Mutators
        //InstructorID
        public int getInstructorID() { return Iid; }
        public void setInstructorID(int id) { Iid = id; }
        //Office #
        public string getOffice() { return Office; }
        public void setOffice(string o) { Office = o; }

        //Instructors' methods()
        public void selectDB(int id)
        {
            DBSetup();
            cmd = "SELECT * FROM Instructors WHERE ID = " + id;
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                Iid = id;
                base.setFname(dr.GetValue(1) + "");
                base.setLname(dr.GetValue(2) + "");
                addr.setStreet(dr.GetValue(3) + "");
                addr.setCity(dr.GetValue(4) + "");
                addr.setState(dr.GetValue(5) + "");
                addr.setZip(Int32.Parse(dr.GetValue(6) + ""));
                setOffice(dr.GetValue(7) + "");
                base.setEmail(dr.GetValue(8) + "");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        }
        public void insertDB()
        {
            DBSetup();
            cmd = "INSERT into Instructors VALUES(" + getInstructorID() + "," +
                                                "" + "\"" + getFname() + "\"" + "," +
                                                "" + "\"" + getLname() + "\"" + "," +
                                                "" + "\"" + addr.getStreet() + "\"" + "," +
                                                "" + "\"" + addr.getCity() + "\"" + "," +
                                                "" + "\"" + addr.getState() + "\"" + "," +
                                                "" + addr.getZip() + "," +
                                                "" + "\"" + getOffice() + "\"" + "," +
                                                "" + "\"" + getEmail() + "\"" + ")";
            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data INSERTed");
                else Console.WriteLine("ERROR: Inserting Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
        public void updateDB()
        {
            DBSetup();
            cmd = "UPDATE Instructors SET FirstName = " + "\"" + getFname() + "\"" + "," +
                                           " LastName = " + "\"" + getLname() + "\"" + "," +
                                           " Street = " + "\"" + addr.getStreet() + "\"" + "," +
                                           " City = " + "\"" + addr.getCity() + "\"" + "," +
                                           " State = " + "\"" + addr.getState() + "\"" + "," +
                                           " Zip = " + addr.getZip() + "," +
                                           " Office = " + "\"" + getOffice() + "\"" + "," + 
                                           " EMail = " + "\"" + getEmail() + "\"" + " " + 
                                           "WHERE ID = " + getInstructorID();
            OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data UPDATEd");
                else Console.WriteLine("ERROR: Updating Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
        public void deleteDB()
        {
            DBSetup();
            cmd = "DELETE from Instructors WHERE ID = " + getInstructorID();
            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data DELETEd");
                else Console.WriteLine("ERROR: Deleting Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
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
        public Address(string personStreet, string personCity, string personState, int zipCode)
        {
            Street = personStreet;
            City = personCity;
            State = personState;
            Zip = zipCode;
        }

        //---Accessors and Mutators
        //State
        public string getState() { return State; }
        public void setState(string s) { State = s; }
        //City
        public string getCity() { return City; }
        public void setCity(string c) { City = c; }
        //Zip
        public int getZip() { return Zip; }
        public void setZip(int z) { Zip = z; }
        //Street
        public string getStreet() { return Street; }
        public void setStreet(string s) { Street = s; }

        //---Address methods()
        public void display()
        {
            Console.WriteLine("Person's address: " + getStreet() + ", " + getCity() + " " + getState() + ", " + getZip());
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

        public void display()
        {
            Section s1 = new Section();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("----------\nSECTION " + (i + 1) + "\n----------");
                s1.display();
            }
            Console.WriteLine("----------");
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
        //Constructor accepting an arguement to look up the Course's ID
        public Course(string pk)
        {
            selectDB(pk);
        }

        //---Accessors and Mutators
        //CourseID
        public string getCourseID() { return CourseID; }
        public void setCourseID(string cid) { CourseID = cid; }
        //Course's Name
        public string getCourseName() { return CourseName; }
        public void setCourseName(string cn) { CourseName = cn; }
        //Description for the Course
        public string getDescription() { return Description; }
        public void setDescription(string desc) { Description = desc; }
        //Credit Hours for the Course
        public int getCreditHours() { return CreditHours; }
        public void setCreditHours(int hrs) { CreditHours = hrs; }


        ////////*+* DATABASE SET UP *+*\\\\\\\\
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection OleDbConnection2;
            public string cmd;

        public void DBSetup()
        {
            OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbConnection2 = new System.Data.OleDb.OleDbConnection();

                OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
                OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
                OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;
                OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;

            OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" +
            "ocking Mode=1;Data Source=C:\\Users\\DefaultTheMighty\\source\\repos\\CsharpProgrammingII-StudentRegistrationSystem\\RegistrationMDB.mdb;J" +
            "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +
            "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
            "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
            "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
            "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
        }

        //---Course methods()
        public void selectDB(string cid)
        {
            DBSetup();
            cmd = "SELECT * FROM Courses WHERE CourseID = " + "\"" + cid + "\"";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                CourseID = cid;
                setCourseName(dr.GetValue(1) + "");
                setDescription(dr.GetValue(2) + "");
                setCreditHours(Int32.Parse(dr.GetValue(3) + ""));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        }
        public void insertDB()
        {
            DBSetup();
            cmd = "INSERT into Courses VALUES(" + "\"" + getCourseID() + "\"" + "," +
                                              "" + "\"" + getCourseName() + "\"" + "," +
                                              "" + "\"" + getDescription() + "\"" + "," +
                                              "" + getCreditHours() + ")";
            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data INSERTed");
                else Console.WriteLine("ERROR: Inserting Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
        public void updateDB()
        {
            DBSetup();
            cmd = "UPDATE Courses SET CourseName = " + "\"" + getCourseName() + "\"" + "," +
                                      "Description = " + "\"" + getDescription() + "\"" + "," +
                                      "CreditHours = " + getCreditHours() + " " + 
                                      "WHERE CourseID = " + "\"" + getCourseID() + "\"";
            OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data UPDATEd");
                else Console.WriteLine("ERROR: Updating Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
        public void deleteDB()
        {
            DBSetup();
            cmd = "DELETE from Courses WHERE CourseID = " + "\"" + getCourseID() + "\"";
            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data DELETEd");
                else Console.WriteLine("ERROR: Deleting Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
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
            private int Iid;

        Course c = new Course();
        Instructor i = new Instructor();

        //Default Constructor
        public Section()
        {

            CRN = 30000;
            c.getCourseID();
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
        //Constructor accepting an arguement to look up the Section's CRN
        public Section(int pk)
        {
            selectDB(pk);
        }


        //---Accessors and Mutators
        //CRN
        public int getCRN() { return CRN; }
        public void setCRN(int courseReferenceNumber) { CRN = courseReferenceNumber; }
        //TimeDays
        public string getTimeDay() { return timeDay; }
        public void setTimeDay(string sectionTimeDay) { timeDay = sectionTimeDay; }
        //Room Number
        public string getRoomNumber() { return roomNo; }
        public void setRoomNumber(string roomNumber) { roomNo = roomNumber; }
        //CourseID
        public string getCourseID() { return CourseID; }
        public void setCourseID(string cid) { CourseID = cid; }
        //InstructorID
        public int getInstructorID() { return Iid; }
        public void setInstructorID(int id) { Iid = id; }

        ////////*+* DATABASE SET UP *+*\\\\\\\\
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection OleDbConnection2;
            public string cmd;

        public void DBSetup()
        {
            OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbConnection2 = new System.Data.OleDb.OleDbConnection();

                OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
                OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
                OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;
                OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;

            OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" +
            "ocking Mode=1;Data Source=C:\\Users\\DefaultTheMighty\\source\\repos\\CsharpProgrammingII-StudentRegistrationSystem\\RegistrationMDB.mdb;J" +
            "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +
            "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
            "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
            "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
            "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
        }

        //---Section methods()
        public void selectDB(int crn)
        {
            DBSetup();

            cmd = "SELECT * FROM Sections where CRN = " + crn;
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                CRN = crn;
                c.setCourseID(dr.GetValue(1) + "");
                setTimeDay(dr.GetValue(2) + "");
                setRoomNumber(dr.GetValue(3) + "");
                i.setInstructorID(Int32.Parse(dr.GetValue(4) + ""));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        }
        public void insertDB()
        {
            DBSetup();

            cmd = "INSERT into Sections VALUES(" + getCRN() + "," +
                                  "" + "\"" + getCourseID() + "\"" + "," +
                                  "" + "\"" + getTimeDay() + "\"" + "," +
                                  "" + "\"" + getRoomNumber() + "\"" + "," +
                                  "" + getInstructorID() + ")";
            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data INSERTed");
                else Console.WriteLine("ERROR: Inserting Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
        public void updateDB()
        {
            DBSetup();

            cmd = "UPDATE Sections SET CourseID = " + "\"" + getCourseID() + "\"" + "," + 
                                      "TimeDays = " + "\"" + getTimeDay() + "\"" + "," + 
                                      "RoomNo = " + "\"" + getRoomNumber() + "\"" + "," +
                                      "Instructor = " + i.getInstructorID() + " " + 
                                      "WHERE CRN = " + getCRN();
            OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data UPDATEd");
                else Console.WriteLine("ERROR: Updating Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
        public void deleteDB()
        {
            DBSetup();

            cmd = "DELETE from Sections WHERE CRN = " + getCRN();
            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data DELETEd");
                else Console.WriteLine("ERROR: Deleting Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { OleDbConnection2.Close(); }
        }
        public void display()
        {
            Console.WriteLine("CRN: " + getCRN());
            Console.WriteLine("Course ID: " + c.getCourseID());
            Console.WriteLine("Time and Day(s) of the week: " + getTimeDay());
            Console.WriteLine("Room #: " + getRoomNumber());
            Console.WriteLine("Taught by Instructor #: " + i.getInstructorID());
        }
    }
}

