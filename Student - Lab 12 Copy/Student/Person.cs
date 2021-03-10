using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************
  William Weldy
  Lab #12
*****************************************************/

/*Your all args constructor  for Student is not correct:

public Student(string nameValue, string idValue, string phoneValue,string emailValue, string addressValue,string majorValue, string gpaValue) : base(nameValue, phoneValue, emailValue, addressValue)
        {
            ID = idValue;
            Major = majorValue;
            GPA = gpaValue;
        }

You were missing the red code I added.

All else looks good...

Thanks...Ron Enz*/

namespace Student
{
    class Person
    {
        private string _name;
        private string _phoneNumber;
        private string _EMail;
        private string _address;

        public Person()
        {
            Name = " ";
            PhoneNumber = "0";
            EMail = " ";
            Address = " ";
        }
        public Person(string nameValue, string phoneValue, string emailValue, string addressValue)
        {
            Name = nameValue;
            PhoneNumber = phoneValue;
            EMail = emailValue;
            Address = addressValue;
        }
        public string Name
        {
            get { return _name; }
            set { _name = ""; }
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

        public void DisplayPerson()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Phone #: " + PhoneNumber);
            Console.WriteLine("E-Mail Address: " + EMail);
            Console.WriteLine("Address: " + Address);
        }
    }
}
