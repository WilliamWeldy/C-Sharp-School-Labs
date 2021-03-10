using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattBank
{
    public partial class LoginForm : Form
    {
        Customer cust = new Customer();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (idText.Text == "" && pwText.Text == "") { //This block does something if you leave both fields blank
                MessageBox.Show("You need to enter your Customer ID and password!!");
            }
            else if (idText.Text == "")
            { //This block does something if you leave only the userID space blank
                MessageBox.Show("You need to enter your Customer ID!");
            }
            else if (pwText.Text == "")
            { //This block does something if you leave only the password space blank
                MessageBox.Show("You need to enter a password!");
            }
            else if (idText.Text == "admin" || idText.Text == "Admin")
            { //This block gives you admin access if you enter the password correctly
                if (pwText.Text == "123")
                {
                    AdminMainForm aForm = new AdminMainForm();
                    aForm.Show();
                }
            }
            else if (idText.Text != "") { //This big block runs a check to make sure blanks aren't ran against the Customers table
                if (pwText.Text != "") {


                    cust.SelectDB(idText.Text); //This takes what you entered and runs it against the database
                    if (idText.Text == cust.getCustID() && pwText.Text == cust.getPassword()) {
                            this.Hide();
                            string passToNextForm = cust.getCustID();
                            CustomerViewAccountsForm cForm = new CustomerViewAccountsForm(passToNextForm);
                            cForm.Show();
                        }
                    else if (idText.Text == cust.getCustID() && pwText.Text != cust.getPassword()) {
                        MessageBox.Show("That password does not match up to the account, please try again");
                    }
                }
            }
        }
    }

    public class Person
    {
        //Class Properties
        private string Fname;
        private string Lname;
        private string Email;
        private string Password;

        //CONSTRUCTORS
            //default constructor
        public Person()
        {

        }
            //parameter constructor
        public Person(string FirstName, string LastName, string EmailAddress, string AccountPassword)
        {
            Fname = FirstName;
            Lname = LastName;
            Email = EmailAddress;
            Password = AccountPassword;
        }


        //ACCESSORS and MUTATORS
            //First Name
        public string getFname()         { return Fname; }
        public void   setFname(string f) { Fname = f; }
            //Last Name
        public string getLname()         { return Lname; }
        public void   setLname(string l) { Lname = l; }
            //Email Address
        public string getEmail()         { return Email; }
        public void   setEmail(string e) { Email = e; }
            //Password
        public string getPassword()         { return Password; }
        public void   setPassword(string p) { Password = p; }

        //METHODS()
        public void Display()
        {
            Console.WriteLine("First Name: " + getFname());
            Console.WriteLine("Last Name: " + getLname());
            Console.WriteLine("E-Mail Address: ");
            Console.WriteLine("User's Password: ");
        }
    }

    public class Admin : Person
    {
        //Class Properties
        private string id = "5";
        private Address addr;

        //CONSTRUCTORS
            //default constructor
        public Admin() : base()
        {

        }
            //parameter constructor, admins are not part of the table itself and don't have any data to modify on there so they don't need DataBase Access Objects
        public Admin(string AdministratorID) : base()
        {
            
        }


        //ACCESSOR and MUTATOR for ID
        public string getAdminID()         { return id; }
        public void   setAdminID(string i) { id = i; }

        //METHODS()
        public void Display()
        {
            base.Display();
            addr.Display();
            Console.WriteLine("Administrator ID: " + getAdminID());
        }
    }

    public class Customer : Person
    {
        //Class Properties
        private string cid;
        private Address addr; //Customer has a full address class ready to be used even though only States are utilized for the DB Table
        private List<Account> cAccounts = new List<Account>(); //An account class

        //CONSTRUCTORS
            //default constructor
        public Customer() : base()
        {

        }
            //The select constructor
        public Customer(string CustomerID) : base()
        {
            SelectDB(cid);
        }


        //ACCESSOR and MUTATOR for ID
        public string getCustID()         { return cid; }
        public void   setCustID(string c) { cid = c; }

        //////////////////////////////DATABASE SETUP\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
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

                "ocking Mode=1;Data Source=c:\\Users\\DefaultTheMighty\\source\\repos\\ChattBank\\ChattBankMDB.mdb;J" +  //*DEV NOTE:  MAKE SURE YOU SWITCH THIS WITH EACH COMPUTER YOU LOG INTO!!!!
                    //DON'T FORGET THE ACCOUNT CLASS EITHER!
                "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +
                "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
                "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
                "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
                "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
            }

        //METHODS()
        public void SelectDB(string id)
        {
            DBSetup(); //objects created & connection established
            cmd = "SELECT * FROM Customers WHERE CustID = " + "\"" + id + "\""; //String of SQL command
            OleDbDataAdapter2.SelectCommand.CommandText = cmd; //The CommandText  gets  the cmd string
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2; //Connection established
            Console.WriteLine(cmd); //Write the  cmd string  to the Console
            try
            {
                OleDbConnection2.Open(); //Open the connection
                System.Data.OleDb.OleDbDataReader dr = OleDbDataAdapter2.SelectCommand.ExecuteReader(); //Assigns "dr" to read the Customers table
                dr.Read();

                //Setting all the data retrieved from the table to the C# classes
                cid = id; //Value (0) to get CustID
                setPassword(dr.GetValue(1) + "");
                setFname(dr.GetValue(2) + "");
                setLname(dr.GetValue(3) + "");
           addr.setState(dr.GetValue(4) + "");
                setEmail(dr.GetValue(5) + "");
            }
            catch (Exception ex) { Console.WriteLine(ex); } //If an exception is thrown, it goes to the console
            finally { OleDbConnection2.Close(); } //Closes the connection after everything is done
        } //end of SELECT

        public void InsertDB()
        {
            DBSetup(); //objects created & connection established
            cmd = "INSERT INTO Customers values(" + "\"" + getCustID() + "\"," + //String of the INSERT command
                                               "" + "\"" + getPassword() + "\"," +
                                               "" + "\"" + getFname() + "\"," +
                                               "" + "\"" + getLname() + "\"," +
                                               "" + "\"" + addr.getState() + "\"," +
                                               "" + "\"" + getEmail() + "\")";
            OleDbDataAdapter2.InsertCommand.CommandText = cmd; //The CommandText  gets  the cmd string
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2; //Connection established
            Console.WriteLine(cmd); //Write the  cmd string  to the Console
            try
            {
                OleDbConnection2.Open(); //Open the connection
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery(); //sets  n  to be the variable to check if everything worked
                  if (n == 1) Console.WriteLine("Data Inserted");
                  else        Console.WriteLine("Error: INSERTing Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); } //If an exception is thrown, it goes to the console
            finally { OleDbConnection2.Close(); } //Closes the connection after everything is done
        } //end of INSERT

        public void UpdateDB()
        {
            DBSetup(); //objects created & connection established
            cmd = "UPDATE Customers SET CustPassword = \"" + getPassword() + "\"," +  //String for the UPDATE command, starting off with the 2ND field the password
                                      "CustFirstName = \"" + getFname() + "\"," +
                                       "CustLastName = \"" + getLname() + "\"," +
                                        "CustAddress = \"" + addr.getState() + "\"," +
                                          "CustEmail = \"" + getEmail() + "\"" +  //the last column doesn't get a ' + "," + ' section since the next column has to identify WHERE to update
                                      " WHERE CustID = \"" + getCustID() + "\""; //the last part is the WHERE command looking for the pk, the 'CustID'
            OleDbDataAdapter2.UpdateCommand.CommandText = cmd; //The Commandtext  gets  the cmd string
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2; //Connection established
            Console.WriteLine(cmd); //Write the  cmd string  to the Console
            try
            {
                OleDbConnection2.Open(); //Open the connection
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery(); //sets  n  to be the variable to check if everything's working
                if (n == 1) Console.WriteLine("Data Updated");
                else        Console.WriteLine("Error: UPDATEing Data");
            }
            catch (Exception ex) { Console.WriteLine(ex); } //If an exception is thrown, it goes to the console
            finally { OleDbConnection2.Close(); } //Closes the connection after everything's done
        } //end of UPDATE

        public void DeleteDB()
        {
        DBSetup(); //objects created & connection established
        cmd = "DELETE FROM Customers WHERE CustID = " + getCustID(); //String to DELETE an item based off the Customer ID
        OleDbDataAdapter2.DeleteCommand.CommandText = cmd; //The CommandText  gets  the cmd string
        OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2; //Connection established
        Console.WriteLine(cmd); //Write the  cmd string to the Console
        try
        {
            OleDbConnection2.Open(); //Open the connection
            int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery(); //sets  n  to be the variable to check if everything worked
            if (n == 1) Console.WriteLine("Data Deleted");
            else        Console.WriteLine("Error: DELETEing Data");
        }
        catch (Exception ex) { Console.WriteLine(ex); } //If an exception is thrown, it goes to the Console
        finally { OleDbConnection2.Close(); } //Closes the connection after everything's done
    } //end of DELETE

        public void Display()
        {
            base.Display();
            addr.Display();
            Console.WriteLine("Customer ID: " + getCustID());
        }
    }


    public class Account
    {
        //Class Properties
        private string acctNum;
        Customer c = new Customer();
        private string type;
        private double balance;

        //CONSTRUCTORS
            //default constructor
        public Account()
        {

        }
            //parameter constructor
        public Account(string AccountType, double AccountBalance, string AccountNumber)
        {
            type = AccountType;
            balance = AccountBalance;
            acctNum = AccountNumber;
        }


        //ACCESSORS and MUTATORS
            //Type
        public string getType()         { return type; }
        public void   setType(string t) { type = t; }
            //Balance
        public double getBalance()         { return balance; }
        public void   setBalance(double b) { balance = b; }
            //Account Number
        public string getNum()         { return acctNum; }
        public void   setNum(string n) { acctNum = n; }

        //////////////////////////////DATABASE SETUP\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
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

                "ocking Mode=1;Data Source=c:\\Users\\DefaultTheMighty\\source\\repos\\ChattBank\\ChattBankMDB.mdb;J" +  //*DEV NOTE:  MAKE SURE YOU SWITCH THIS WITH EACH COMPUTER YOU LOG INTO!!!!
                    //DON'T FORGET THE CUSTOMER CLASS EITHER!
                "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +
                "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
                "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
                "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
                "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
            }

        //METHODS()
        public void SelectDB(string acctNo)
        {
            DBSetup(); //objects created & connection established
            cmd = "SELECT * FROM Accounts WHERE AcctNo = " + "\"" + acctNo + "\""; //String of SQL command
            //cmd = "SELECT * FROM Accounts WHERE Cid = " + "\"" + acctNo + "\""; //String of SQL command
            OleDbDataAdapter2.SelectCommand.CommandText = cmd; //The CommandText  gets  the cmd string
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2; //Connection established
            Console.WriteLine(cmd); //Write the  cmd string  to the Console
            try
            {
                OleDbConnection2.Open(); //Open the connection
                System.Data.OleDb.OleDbDataReader dr = OleDbDataAdapter2.SelectCommand.ExecuteReader(); //Assigns "dr" to read the Customers table
                dr.Read();

                //Setting all the data retrieved from the table to the C# classes
                acctNum = acctNo; //Value (0) to get acctNo, the primary key for this table
              c.setCustID(dr.GetValue(1) + "");
                setType(dr.GetValue(2) + "");
                setBalance(Double.Parse(dr.GetValue(3) + ""));
            }
            catch (Exception ex) { Console.WriteLine(ex); } //If an exception is thrown, it goes to the console
            finally { OleDbConnection2.Close(); } //Closes the connection after everything is done
        } //end of SELECT
        public void InsertDB()
        {
            DBSetup();
            cmd = "INSERT INTO Accounts values(" + "\"" + getNum() + "\"," + //String of the INSERT command
                                               "" + "\"" + c.getCustID() + "\"," +
                                               "" + "\"" + getType() + "\"," +
                                               "" + "\"" + getBalance() + "\")";
            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data INSERTed");
                else Console.WriteLine("ERROR: INSERTing data");
            }
            catch (Exception ex) { Console.WriteLine(ex); } //If an exception is thrown, it goes to the console
            finally { OleDbConnection2.Close(); } //Closes the connection after everything is done
        } //end of INSERT
        public void UpdateDB()
        {
            DBSetup();
            cmd = "UPDATE Accounts set Cid = \"" + c.getCustID() + "\"," +  //String for the UPDATE command, starting off with the 2ND field being the foreign key
                                     "Type = \"" + getType() + "\"," + 
                                  "Balance = \"" + getBalance() + "\"" + //last column doesn't get a ' + "," + ' section since the next column has to identify WHERE to update
                            " WHERE AcctNo = \"" + getNum() + "\"";
            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data UPDATEed");
                else Console.WriteLine("ERROR: UPDATEing data");
            }
            catch (Exception ex) { Console.WriteLine(ex); } //If an exception is thrown, it goes to the console
            finally { OleDbConnection2.Close(); } //Closes the connection after everything is done
        } //end of UPDATE
        public void DeleteDB()
        {
            DBSetup();
            cmd = "DELETE FROM Accounts WHERE AcctNo = " + getNum();
            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1) Console.WriteLine("Data DELETEed");
                else Console.WriteLine("ERROR: DELETEing data");
            }
            catch (Exception ex) { Console.WriteLine(ex); } //If an exception is thrown, it goes to the console
            finally { OleDbConnection2.Close(); } //Closes the connection after everything is done
        } //end of DELETE
        public void Display()
        {
            Console.WriteLine("Account Type: " + getType());
            Console.WriteLine("Account Number: " + getNum());
            Console.WriteLine("Customer Balance: $" + getBalance());
        }
    }


    public class Address
    {
        //Class Properties
        private string Street;
        private string City;
        private string State;
        private string ZIP;

        //CONSTRUCTORS
            //default constructor
        public Address()
        {

        }
            //parameter constructor
        public Address(string StreetAddress, string CityAddress, string ResidentState, string ZipCode)
        {
            Street = StreetAddress;
            City = CityAddress;
            State = ResidentState;
            ZIP = ZipCode;
        }


        //ACCESSORS and MUTATORS
            //Street
        public string getStreet()         { return Street; }
        public void   setStreet(string s) { Street = s; }
            //City
        public string getCity()         { return City; }
        public void   setCity(string c) { City = c; }
            //State
        public string getState()         { return State; }
        public void   setState(string s) { State = s; }
            //ZIP Code
        public string getZIP()         { return ZIP; }
        public void   setZIP(string z) { ZIP = z; }

        //METHODS()
        public void Display()
        {
            Console.WriteLine(" The User's Address: " + getStreet() + ", " + getCity() + ", " + getState() + " " + getZIP());
        }
    }
}
