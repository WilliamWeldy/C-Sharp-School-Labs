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
  Lab #12
*****************************************************/

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e){}

        //List<Student> Students = new List<Student>();
        Student s1 = new Student();

        private void displayBtn_Click(object sender, EventArgs e)
        {
            s1.DisplayStudent();
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            s1.Name = nameText.Text;
            s1.ID = idText.Text;
            s1.PhoneNumber = phoneText.Text;
            s1.EMail = emailText.Text;
            s1.Address = addressText.Text;
            s1.Major = majorText.Text;
            s1.GPA = gpaText.Text;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit this program?", "Student Creation Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
