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
    public partial class availableProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public availableProducts()
        {
            InitializeComponent();
            displayAllAvailableProducts();
        }

        public void displayAllAvailableProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.allaAvailableproductsData();

            dataGridView1.DataSource = listData;
        }
        private void dataGridView1_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string keyword = searchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                displayAllAvailableProducts(); // Show all if empty
                return;
            }

            try
            {
                connect.Open();

                string query = "SELECT * FROM products WHERE status = @status AND (prod_name LIKE @keyword OR prod_id LIKE @keyword OR category LIKE @keyword)";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Available");
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No matching items found.");
                        }
                        else
                        {
                            MessageBox.Show("Item found !");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void searchButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(this, new EventArgs());
            }
        }
    }
}
