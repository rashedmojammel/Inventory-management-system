using System.Data;
using System.Data.SqlClient;

namespace Invetory_Management_System
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM users where username = @usern AND password = @pass";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Active");

                        int rowCount = (int)cmd.ExecuteScalar();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (rowCount > 0)
                        {
                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass ";

                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern ", login_username.Text.Trim());

                                getRole.Parameters.AddWithValue("@pass ", login_password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;
                                MessageBox.Show("Login Succcessfully !", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (userRole == "Admin")
                                {
                                    MainForm mform = new MainForm();
                                    mform.Show();
                                    this.Hide();

                                    MessageBox.Show("Wellcome Admin !", "Welcome !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                                }
                                else if (userRole == "Cashier")
                                {
                                    CashierMainForm cmform = new CashierMainForm();
                                    cmform.Show();
                                    this.Hide();


                                }
                                else if (userRole == "Customer")
                                {
                                    CustomerMainForm cmmForm = new CustomerMainForm();
                                    cmmForm.Show();
                                    this.Hide();
                                }


                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password or there's no admin's approval",
                                "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    //else
                    //{
                    //    MessageBox.Show("Incorrect username/password or there's no admin's approval",
                    //        "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                catch
                {
                    //MessageBox.Show("Connection Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Incorrect username/password!",
                               "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            RegisterForm RegForm = new RegisterForm();
            RegForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassoword.Checked ? '\0' : '*';
        }
        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
