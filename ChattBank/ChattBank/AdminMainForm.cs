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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void mainToTestformBtn_Click(object sender, EventArgs e)
        {
            AdminTestClassesForm atcfForm = new AdminTestClassesForm();
            atcfForm.Show();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            AdminCustomerCreateForm accfForm = new AdminCustomerCreateForm();
            accfForm.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            AdminCustomerDeleteForm acdfForm = new AdminCustomerDeleteForm();
            acdfForm.Show();
        }


        //Menu form log out button
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm mainForm = new LoginForm();
            mainForm.Show();
        }
    }
}
