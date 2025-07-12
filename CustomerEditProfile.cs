using System.Data.SqlClient;

namespace Invetory_Management_System
{
    public partial class CustomerEditProfile : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public CustomerEditProfile()
        {
            InitializeComponent();
        }
        private int currentUserId;
        private void LoadCurrentUserData()
        {
            try
            {
                string connectionString = "your_connection_string_here";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Username, Password FROM Customers WHERE Id = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", currentUserId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                addUsers_username.Text = reader["Username"].ToString();
                                addUser_Password.Text = reader["Password"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }
       

        private void addUser_updateBtn_Click(object sender, EventArgs e)
        {
            string newUsername = addUsers_username.Text.Trim();
            string newPassword = addUser_Password.Text.Trim();

            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connect.Open();

                // Optional: check for username conflict
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username AND id != @id";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connect))
                {
                    checkCmd.Parameters.AddWithValue("@username", newUsername);
                    checkCmd.Parameters.AddWithValue("@id", currentUserId);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username already taken. Please choose another.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update
                string updateQuery = "UPDATE users SET username = @username, password = @password WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@username", newUsername);
                    cmd.Parameters.AddWithValue("@password", newPassword);
                    cmd.Parameters.AddWithValue("@id", currentUserId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCurrentUserData(); // Refresh data

                // Optional: clear inputs
                addUsers_username.Clear();
                addUser_Password.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void addUser_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addUsers_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
