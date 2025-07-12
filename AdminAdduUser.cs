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
    public partial class AdminAdduUser : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public AdminAdduUser()
        {
            InitializeComponent();
        }

        private void addUser_addBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUser_Password.Text == "" || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Feilds ", "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    String checkUsername = "SELECT * FROM users WHERE username = @usern";
                    using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show(addUsers_username.Text.Trim() + " is already taken ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users(username,password,role,status,date)" +
                                "VALUES(@usern, @pass, @role, @status, @date)";
                            using(SqlCommand insertD = new SqlCommand(insertData,connect))
                            {
                                insertD.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                insertD.Parameters.AddWithValue("@pass", addUser_Password.Text.Trim());
                                insertD.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                                insertD.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;
                                insertD.Parameters.AddWithValue("@date" ,today);
                                insertD.ExecuteNonQuery();
                                MessageBox.Show("Added succesfully ", "Information message ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Connection Failed" + ex, "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

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
    }
}
