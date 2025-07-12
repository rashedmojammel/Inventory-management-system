using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient; 
namespace Invetory_Management_System
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_label_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {
        }

        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void register_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPassword.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPassword.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {
                MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkUsername = "SELECT * FROM users WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(register_username.Text.Trim() + " is already taken", "Error Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password, at least 8 characters needed",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Trim() != register_cPassword.Text.Trim())
                            {
                                MessageBox.Show("Passwords do not match.",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, role, status, date,gender, phone, email) " +
                                    "VALUES(@usern, @pass, @role, @status, @date,@gender, @phone, @email)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", "Approval");
                                    insertD.Parameters.AddWithValue("@status", "Pending");
                                    insertD.Parameters.AddWithValue("@date", DateTime.Today);
                                    insertD.Parameters.AddWithValue("@gender", register_gender.Text.Trim());
                                    insertD.Parameters.AddWithValue("@phone", register_phone.Text.Trim());
                                    insertD.Parameters.AddWithValue("@email", register_email.Text.Trim());


                                    insertD.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!", "Information",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
