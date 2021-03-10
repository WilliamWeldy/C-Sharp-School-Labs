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
    public partial class AdminTestClassesForm : Form
    {
        public AdminTestClassesForm()
        {
            InitializeComponent();
        }

        //Buttons for testing classes
        private void personBtn_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Display();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Display();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Display();
        }

        private void acctBtn_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Display();
        }

        private void addressBtn_Click(object sender, EventArgs e)
        {
            Address a = new Address();
            a.Display();
        }


        //Menu form navigation buttons
        private void goBackBtn_Click(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
