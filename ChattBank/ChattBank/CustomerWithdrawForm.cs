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
    public partial class CustomerWithdrawForm : Form
    {
        Customer cust = new Customer();
        Account acct = new Account();

        public CustomerWithdrawForm()
        {
            InitializeComponent();
        }

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

        private void withdrawTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            withdraw();
        }

        private void withdraw()
        {
            double b = acct.getBalance();
            double withdraw = Double.Parse(withdrawTxt.Text);

            acct.setBalance(b - withdraw);
            acct.InsertDB();
            successLbl.Text = "($" + withdraw + ") was withdrawn from your selected account.";
        }
    }
}
