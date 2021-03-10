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
    public partial class AdminCustomerCreateForm : Form
    {
        Customer cust = new Customer();
        Account acct = new Account();

        public AdminCustomerCreateForm()
        {
            InitializeComponent();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            cust.InsertDB();
            acct.InsertDB();
        }
    }
}
