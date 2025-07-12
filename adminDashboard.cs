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
    public partial class adminDashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public adminDashboard()
        {
            InitializeComponent();
            displayTodaysCustomer();
            displayAllUsers();
            displayAllCustomers();
            displayTodaysIncome();
            displayTotalIncome();
        }
        public void displayTodaysCustomer()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.allTodayCustomers();
            dataGridView4.DataSource = listData;
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
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
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM users WHERE status = @status";

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
                            dashboard_AC.Text = count.ToString();
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
        public void displayTodaysIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(total_price) FROM customers WHERE order_date = @date";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        DateTime today = DateTime.Today;

                        string getToday = today.ToString("yyyy-MM-dd");

                        cmd.Parameters.AddWithValue("@date",getToday);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {

                            object value = reader[0];

                            if(value != DBNull.Value)
                            {
                                int count = Convert.ToInt32(reader[0]);
                                dashboard_TI.Text ="BDT" + count.ToString("0.000");

                            }
                            
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
        public void displayTotalIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(total_price) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {

                           
                            
                                int count = Convert.ToInt32(reader[0]);
                            dashboard_totalIncome.Text = "BDT" + count.ToString("0.000");

                            

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
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
