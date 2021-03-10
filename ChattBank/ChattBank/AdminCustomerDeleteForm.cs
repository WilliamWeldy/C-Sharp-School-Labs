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
    public partial class AdminCustomerDeleteForm : Form
    {
        Customer cust = new Customer();
        Account acct = new Account();

        public AdminCustomerDeleteForm()
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            cust.SelectDB(idTxt.Text);
            if (MessageBox.Show("Are you  absolutely  sure? Deleting a customer results in permanent removal from the database table.", "BEFORE YOU CLICK YES!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cust.DeleteDB();
            }
        }
    }
}
