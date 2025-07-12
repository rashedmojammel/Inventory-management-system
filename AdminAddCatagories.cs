using System.Data;
using System.Data.SqlClient;

namespace Invetory_Management_System
{


    public partial class AdminAddCatagories : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public AdminAddCatagories()
        {
            InitializeComponent();
            displayCategoriesData();
        }
        public void displayCategoriesData()
        {
            CategoriesData cData = new CategoriesData();
            List<CategoriesData> listData = cData.AllCatagoriesData();
            dataGridView1.DataSource = listData;


        }
        private void addCatagories_addBtn_Click(object sender, EventArgs e)
        {
            if (addCatagories_catagories.Text == "")
            {
                MessageBox.Show("Empty feilds", "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        String checkCat = "SELECT * FROM categories WHERE category = @cat";

                        using (SqlCommand cmd = new SqlCommand(checkCat, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", addCatagories_catagories.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Category :" + addCatagories_catagories.Text.Trim() + "is already exists "
                                    , "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO categories(category,date)VALUES(@cat,@date)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@cat", addCatagories_catagories.Text.Trim());
                                    DateTime Today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", Today);
                                    insertD.ExecuteNonQuery();
                                    clearFeilds();
                                    displayCategoriesData();
                                    MessageBox.Show("Added succesfully ", "Infromation message ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed " + ex, "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();

                    }
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
        public void clearFeilds()
        {
            addCatagories_catagories.Text = "";
        }
        private void addCatagories_clearBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                addCatagories_catagories.Text = row.Cells[1].Value.ToString();
            }
        }

        private void addCatagories_updateBtn_Click(object sender, EventArgs e)
        {
            if (addCatagories_catagories.Text == "")
            {
                MessageBox.Show("Empty feilds", "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure want to update this Cat id :" + getID + " ?",
                    "Confirmation message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE categories SET category = @cat WHERE  id =@id";
                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@cat", addCatagories_catagories.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                clearFeilds();
                                displayCategoriesData();
                                MessageBox.Show("Update succesfully ", "Infromation message ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed " + ex, "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();

                        }



                    }
                }

            }
        }

        private void addCatagories_removeBtn_Click(object sender, EventArgs e)
        {
            if (addCatagories_catagories.Text == "")
            {
                MessageBox.Show("Empty feilds", "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure want to Remove this Cat id :" + getID + " ?",
                    "Confirmation message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM categories WHERE id =@id";
                            using (SqlCommand deleteD = new SqlCommand(deleteData, connect))
                            {
                                deleteD.Parameters.AddWithValue("@id", getID);

                                deleteD.ExecuteNonQuery();
                                clearFeilds();
                                displayCategoriesData();
                                MessageBox.Show("Removed succesfully ! ", "Infromation message ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed " + ex, "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


