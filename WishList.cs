using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Invetory_Management_System
{
    public partial class WishList : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public WishList()
        {
            InitializeComponent();
        }

        private void DonateBtn_Click(object sender, EventArgs e)
        {
            string productName = ReqProdName.Text;
            int quantity = (int)Rq_qty.Value;
            string customerName = ReqName.Text;
            DateTime now = DateTime.Now;

            using (SqlConnection con = new SqlConnection("YourConnectionString"))
            {
                string query = "INSERT INTO WishlistRequests (CustomerName, ProductName, ProductQuantity, RequestDate) " +
                               "VALUES (@CustomerName, @ProductName, @Quantity, @RequestDate)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@RequestDate", now);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Request submitted successfully.");
            }
        }
    }
}
