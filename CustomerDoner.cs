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
using System.Xml.Linq;

namespace Invetory_Management_System
{
    public partial class CustomerDoner : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public CustomerDoner()
        {
            InitializeComponent();
            //LoadDonations();
        }

        private void DonateBtn_Click(object sender, EventArgs e)
        {
            string name = DonerName.Text.Trim();
            string phone = DonerPhoneN.Text.Trim();
            string amountText = DonerAmount.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(amountText))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount))
            {
                MessageBox.Show("Enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();
                string query = "INSERT INTO Donations (CustomerName, PhoneNumber, Amount, DonationDate) VALUES (@name, @phone, @amount, @date)";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@name", DonerName.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", DonerPhoneN.Text.Trim());
                    cmd.Parameters.AddWithValue("@amount", DonerAmount.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thank you for your donation!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                //LoadDonations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Donation failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
        private void ClearFields()
        {
            DonerName.Clear();
            DonerAmount.Clear();
            DonerPhoneN.Clear();
        }
        private void Doner_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();

        }
        //private void LoadDonations()
        //{
        //    try
        //    {
        //        connect.Open();
        //        string query = "SELECT CustomerName,PhoneNumber, Amount, DonationDate FROM Donations ORDER BY DonationDate DESC";
        //        using (SqlDataAdapter adapter = new SqlDataAdapter(query, connect))
        //        {
        //            DataTable dt = new DataTable();
        //            adapter.Fill(dt);
        //            dataGridView1.DataSource = dt;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Failed to load donations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        connect.Close();
        //    }
        //}
    }
}
