using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;


namespace Invetory_Management_System
{
    public partial class AdminViewDonations : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public AdminViewDonations()
        {
            InitializeComponent();
            LoadDonations();
        }


        private void LoadDonations()
        {
            try
            {
                connect.Open();
                string query = "SELECT CustomerName, PhoneNumber, Amount, DonationDate FROM Donations ORDER BY DonationDate DESC";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connect))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading donations: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void DonateBtn_Click(object sender, EventArgs e)
        {
            string name = DonorSearch.Text.Trim();

            try
            {
                connect.Open();

                string query = @"SELECT CustomerName, PhoneNumber, Amount, DonationDate 
                     FROM Donations 
                     WHERE (@name = '' OR CustomerName LIKE '%' + @name + '%')
                     ORDER BY DonationDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@name", name);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Search result found!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No matching donor found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering donations: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }


        }

        private void Donor_recipt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Safely access columns by name
                string name = selectedRow.Cells["CustomerName"].Value?.ToString() ?? "";
                string phone = selectedRow.Cells["PhoneNumber"].Value?.ToString() ?? "";
                string amount = selectedRow.Cells["Amount"].Value?.ToString() ?? "";
                string date = selectedRow.Cells["DonationDate"].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Please select a donation record to print.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            printDoc.PrintPage += PrintDoc_PrintPage;
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            preview.ShowDialog();
        }

        PrintDocument printDoc = new PrintDocument();

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            string receipt = "---- Donation Receipt ----\n\n" +
                             $"Name: {row.Cells["CustomerName"].Value}\n" +
                             $"Phone: {row.Cells["PhoneNumber"].Value}\n" +
                             $"Amount: {row.Cells["Amount"].Value} USD\n" +
                             $"Date: {Convert.ToDateTime(row.Cells["DonationDate"].Value):f}\n\n" +
                             "Thank you for your donation!";

            e.Graphics.DrawString(receipt, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
        }
    }
}

