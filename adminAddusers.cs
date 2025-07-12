using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Invetory_Management_System
{
    public partial class adminAddusers : UserControl
    {
        public adminAddusers()
        {
            InitializeComponent();
            displayAllUsersData();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");

        public void displayAllUsersData()
        {
            UsersData uData = new UsersData();
            List<UsersData> listData = uData.AlluserData();
            dataGridView1.DataSource = listData;
        }

        private void addUser_addBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUser_Password.Text == "" || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    string checkUsername = "SELECT * FROM users WHERE username = @usern";
                    using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(addUsers_username.Text.Trim() + " is already taken", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users(username, password, role, status, date) VALUES(@usern, @pass, @role, @status, @date)";
                            using (SqlCommand insertD = new SqlCommand(insertData, connect))
                            {
                                insertD.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                insertD.Parameters.AddWithValue("@pass", addUser_Password.Text.Trim());
                                insertD.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                                insertD.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());
                                insertD.Parameters.AddWithValue("@date", DateTime.Today);

                                insertD.ExecuteNonQuery();
                                clearField();
                                displayAllUsersData();
                                MessageBox.Show("Added successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed: " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;
        }

        public void clearField()
        {
            addUsers_username.Text = "";
            addUser_Password.Text = "";
            addUser_role.SelectedIndex = -1;
            addUser_status.SelectedIndex = -1;
        }

        private void addUser_clearBtn_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void addUser_updateBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUser_Password.Text == "" || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update user ID: " + getID + "?", "Confirmation message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE users SET username = @usern, password = @pass, role = @role, status = @status, date = @date WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                updateD.Parameters.AddWithValue("@pass", addUser_Password.Text.Trim());
                                updateD.Parameters.AddWithValue("@role", addUser_role.SelectedItem);
                                updateD.Parameters.AddWithValue("@status", addUser_status.SelectedItem);
                                updateD.Parameters.AddWithValue("@date", DateTime.Today);
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                clearField();
                                displayAllUsersData();
                                MessageBox.Show("Updated successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed: " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;

                addUsers_username.Text = row.Cells[1].Value.ToString();
                addUser_Password.Text = row.Cells[2].Value.ToString();
                addUser_role.Text = row.Cells[3].Value.ToString();
                addUser_status.Text = row.Cells[4].Value.ToString();
            }
        }

        private void addUser_removeBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUser_Password.Text == "" || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove user ID: " + getID + "?", "Confirmation message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "DELETE FROM users WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                clearField();
                                displayAllUsersData();
                                MessageBox.Show("Removed successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed: " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }

        }
    }
}
