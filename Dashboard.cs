using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Invetory_Management_System
{
    public partial class Dashboard : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public Dashboard()
        {
            InitializeComponent();
            displayTodaysCustomer();
            displayAllUsers();
            displayAllCustomers();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void displayTodaysCustomer()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.allTodayCustomers();
            dataGridView1.DataSource = listData;
        }

        public bool checkConnection()
        {
            if(connect.State == ConnectionState.Closed)
            {
                return true;

            }
            else
            {
                return false;
                
            }

        }

        public void displayAllUsers()
        {
            if(checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM users WHERE status = @status";

                    using(SqlCommand cmd = new SqlCommand(selectData,connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();
                        
                        if(reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AU.Text = count.ToString();
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Connection Failed:" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();

                }
            }

        }

        public void displayAllCustomers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AU.Text = count.ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed:" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();

                }
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
