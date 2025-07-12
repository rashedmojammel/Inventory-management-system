using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invetory_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to close?", "Confirmation message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void admin_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Logout?", "Confirmation message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddusers1.Visible = false;
            adminAddCatagories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
            adminViewDonations1.Visible = false;

        }

        private void adminAddusers4_Load(object sender, EventArgs e)
        {

        }

        private void admin_addUser_Click(object sender, EventArgs e)
        {

            adminDashboard1.Visible = false;
            adminAddusers1.Visible = true;
            adminAddCatagories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
            adminViewDonations1.Visible = false;
        }

        private void admin_addCatagories_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddusers1.Visible = false;
            adminAddCatagories1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
            adminViewDonations1.Visible = false;
        }

        private void admin_addProducts_Click(object sender, EventArgs e)
        {

            adminDashboard1.Visible = false;
            adminAddusers1.Visible = false;
            adminAddCatagories1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierCustomerForm1.Visible = false;
            adminViewDonations1.Visible = false;
        }

        private void admin_customer_Click(object sender, EventArgs e)
        {

            adminDashboard1.Visible = false;
            adminAddusers1.Visible = false;
            adminAddCatagories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = true;
            adminViewDonations1.Visible = false;
        }

        private void cashierCustomerForm1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddusers1.Visible = false;
            adminAddCatagories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
            adminViewDonations1.Visible = true;
            
        }
    }
}
