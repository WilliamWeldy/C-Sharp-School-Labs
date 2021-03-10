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
    public partial class CustomerViewAccountsForm : Form
    {
        Customer cust = new Customer();
        Account acct = new Account();

        bool FirstClick = true;
            bool checking = false;
            bool saving = false;
            bool mma = false;

        bool informTextRemoved = false; //boolean for removing the text in the listbox telling you what it is if you click on it and make room for actual accounts

        string cid;

        public CustomerViewAccountsForm()
        {
            InitializeComponent();
        }

        public CustomerViewAccountsForm(string customerID)
        {
            InitializeComponent();
            cust.SelectDB(customerID);
            cid = customerID;
        }

        private void CustomerViewAccountsForm_Load(object sender, EventArgs e)
        {
            welcomeLbl.Text = "Welcome back to your Chattbank account, " + cust.getFname() + "!";
        }

        private void accountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sets ACCOUNT to be Deposited/Withdrawn
        }


        private void createBtn_Click(object sender, EventArgs e)
        {
            if(FirstClick==true)
            {
                checkingBtn.Show();
                savingsBtn.Show();
                mmaBtn.Show();
                createBtn.Hide();
                selectAcctLbl.Show();
                FirstClick = false;
            }
            else if(FirstClick==false) {
                acct.SelectDB(acct.getNum());
                accountListBox.Items.Add(acct.getType() + "$" + acct.getBalance().ToString());
                if (checking==true) {
                    
                }
                else if (saving == true) {

                }
                else if (mma == true) {

                }
            }
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            CustomerDepositForm cdForm = new CustomerDepositForm();
            cdForm.Show();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            CustomerWithdrawForm cwForm = new CustomerWithdrawForm();
            cwForm.Show();
        }


        //LogOut Button
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm mainForm = new LoginForm();
            mainForm.Show();
        }

        //Creating accounts
        private void checkingBtn_CheckedChanged(object sender, EventArgs e)
        {
            selectAcctLbl.Hide();
            createBtn.Show();
            checking = true;
            saving = false;
            mma = false;
        }

        private void savingsBtn_CheckedChanged(object sender, EventArgs e)
        {
            selectAcctLbl.Hide();
            createBtn.Show();
            checking = false;
            saving = true;
            mma = false;
        }

        private void mmaBtn_CheckedChanged(object sender, EventArgs e)
        {
            selectAcctLbl.Hide();
            createBtn.Show();
            checking = false;
            saving = false;
            mma = true;
        }
    }
}
