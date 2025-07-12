using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Invetory_Management_System
{
    public partial class CustomerMainForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public CustomerMainForm()
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

        private void admin_Dashboard_Click(object sender, EventArgs e)
        {
        }

        private void Edit_Profile_Click(object sender, EventArgs e)
        {

        }

        private void customerPlaceOrders1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void Customer_AvailablePro_Click(object sender, EventArgs e)
        {
            productGallery1.Visible = true;
            customerPlaceOrders1.Visible = false;
            customerEditProfile1.Visible = false;
            customerDoner1.Visible = false;
        }

        private void Customer_placeorder_Click(object sender, EventArgs e)
        {
            productGallery1.Visible = false;
            customerPlaceOrders1.Visible = true;
            customerEditProfile1.Visible = false;
            customerDoner1.Visible = false;
        }

        private void Customer_EditProfile_Click(object sender, EventArgs e)
        {
            productGallery1.Visible = false;
            customerPlaceOrders1.Visible = false;
            customerEditProfile1.Visible = true;
            customerDoner1.Visible = false;
        }

        private void Customer_Donate_Click(object sender, EventArgs e)
        {
            productGallery1.Visible = false;
            customerPlaceOrders1.Visible = false;
            customerEditProfile1.Visible = false;
            customerDoner1.Visible = true;
        }
    }
}
