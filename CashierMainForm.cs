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
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
        }

        private void cashier_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to logout ?", "Confirmation message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginform = new Form1();
                loginform.Show();
                this.Hide();

            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to logout ?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            { }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
            cashierOrder1.Visible = false;
        }

        private void addproducts_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierCustomerForm1.Visible = false;
            cashierOrder1.Visible = false;
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = true;
            cashierOrder1.Visible = false;
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
            cashierOrder1.Visible = true;
        }
    }
}
