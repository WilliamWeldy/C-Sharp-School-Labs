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
    public partial class CustomerDepositForm : Form
    {
        Customer cust = new Customer();
        Account acct = new Account();

        public CustomerDepositForm()
        {
            InitializeComponent();
        }

        private void depositTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            Deposit();
        }

        private void Deposit()
        {
            double b = acct.getBalance();
            double deposit = Double.Parse(depositTxt.Text);

            acct.setBalance(b + deposit);
            acct.InsertDB();
            successLbl.Text = "$" + deposit + " was deposited to your selected account.";
        }

        //LogOut Button
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            /*this.Close();
            LoginForm mainForm = new LoginForm();
            mainForm.Show();*/
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
