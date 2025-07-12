using System.Data;
using System.Data.SqlClient;
namespace Invetory_Management_System
{
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public AdminAddProducts()
        {
            InitializeComponent();
            displayCatagories();
            displayAllProducts();
        }
        public void displayAllProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.AllProductsData();

            dataGridView1.DataSource = listData;
        }
        public bool EmptyFeilds()
        {
            if (addProducts_proID.Text == "" || addProducts_proName.Text == "" || addProducts_category.SelectedIndex == -1 ||
               addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void displayCatagories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM categories";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        //SqlDataAdapter adapter = new SqlDataAdapter();
                        //DataTable table = new DataTable();

                        //addProducts_category.DataSource = table;

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                addProducts_category.Items.Add(reader["category"].ToString());
                            }

                        }

                    }

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            //if (EmptyFeilds())
            //{
            //    MessageBox.Show("Empty Feilds ","Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    if (checkConnection())
            //    {
            //        try
            //        {
            //            connect.Open();

            //            string selectData = "SELECT * FROM products WHERE prod_id = @prodID";

            //            using (SqlCommand cmd = new SqlCommand(selectData, connect))
            //            {
            //                cmd.Parameters.AddWithValue("@prodID", addProducts_proID.Text.Trim());
            //                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //                DataTable table = new DataTable();

            //                adapter.Fill(table);

            //                if (table.Rows.Count > 0)
            //                {
            //                    MessageBox.Show("Produt ID :" + addProducts_proID.Text.Trim() + "is existing already ",
            //                        "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }
            //                else
            //                {
            //                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            //                    string relativePath = Path.Combine("Product_Directory ", addProducts_proID.Text.Trim() + ".jpg");
            //                    string path = Path.Combine(baseDirectory, relativePath);
            //                    string directoryPath = Path.GetDirectoryName(path);
            //                    if (!Directory.Exists(directoryPath))
            //                    {
            //                        Directory.CreateDirectory(directoryPath);
            //                    }
            //                    File.Copy(addProducts_imageView.ImageLocation, path, true);




            //                    string insertData = "INSERT INTO products(prod_id,prod_name,category, price, image_path,status,date_insert)" +
            //                        "VALUES(@prodID,@prodName,@cat,@price,@stock,@path,@status,@date)";

            //                    using (SqlCommand insertD = new SqlCommand(insertData, connect))
            //                    {
            //                        insertD.Parameters.AddWithValue("@prodID ", addProducts_proID.Text.Trim());
            //                        insertD.Parameters.AddWithValue("@prodName", addProducts_proName.Text.Trim());
            //                        insertD.Parameters.AddWithValue("@cat ", addProducts_category.Text.Trim());
            //                        insertD.Parameters.AddWithValue("@price ", addProducts_price.Text.Trim());
            //                        insertD.Parameters.AddWithValue("@stock ", addProducts_stock.Text.Trim());
            //                        insertD.Parameters.AddWithValue("@path ", path);
            //                        insertD.Parameters.AddWithValue("@status ", addProducts_status.Text.Trim());

            //                        DateTime Today = DateTime.Today;
            //                        insertD.Parameters.AddWithValue("@date ", Today);

            //                        insertD.ExecuteNonQuery();
            //                        MessageBox.Show("Added successfully ", "Information message ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //                    }
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Failed Connection :" + ex, "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        finally
            //        {
            //            connect.Close();
            //        }
            //    }

            //}
            if (EmptyFeilds())
            {
                MessageBox.Show("Empty Fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@prodID", addProducts_proID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Product ID: " + addProducts_proID.Text.Trim() + " already exists.",
                                    "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                                string folderName = "Product_Directory";
                                string fileName = addProducts_proID.Text.Trim() + ".jpg";

                                string directoryPath = Path.Combine(baseDirectory, folderName);


                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                string fullPath = Path.Combine(directoryPath, fileName);


                                if (!string.IsNullOrEmpty(addProducts_imageView.ImageLocation) && File.Exists(addProducts_imageView.ImageLocation))
                                {
                                    File.Copy(addProducts_imageView.ImageLocation, fullPath, true);
                                }
                                else
                                {
                                    MessageBox.Show("Selected image file not found.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }


                                string insertData = "INSERT INTO products(prod_id, prod_name, category, price, image_path, stock, status, date_insert) " +
                                                    "VALUES(@prodID, @prodName, @cat, @price, @path, @stock, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@prodID", addProducts_proID.Text.Trim());
                                    insertD.Parameters.AddWithValue("@prodName", addProducts_proName.Text.Trim());
                                    insertD.Parameters.AddWithValue("@cat", addProducts_category.Text.Trim());
                                    insertD.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                    insertD.Parameters.AddWithValue("@path", fullPath);
                                    insertD.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                    insertD.Parameters.AddWithValue("@status", addProducts_status.Text.Trim());

                                    DateTime Today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", Today);

                                    insertD.ExecuteNonQuery();
                                    clearFeilds();
                                    displayAllProducts();
                                    MessageBox.Show("Added successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                       

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
            if (connect.State != ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void addProducts_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg; *.png)|*.jpg; *png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addProducts_imageView.ImageLocation = imagePath;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearFeilds()
        {
            addProducts_proID.Text = "";
            addProducts_proName.Text = "";
            addProducts_category.SelectedIndex = -1;
            addProducts_price.Text = "";
            addProducts_stock.Text = "";
            addProducts_status.SelectedIndex = -1;
            addProducts_imageView.Image = null;
        }
        private void addProducts_ClearBtn_Click(object sender, EventArgs e)
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

                addProducts_proID.Text = row.Cells[1].Value.ToString();
                addProducts_proName.Text = row.Cells[2].Value.ToString();
                addProducts_category.Text = row.Cells[3].Value.ToString();
                addProducts_price.Text = row.Cells[4].Value.ToString();
                addProducts_stock.Text = row.Cells[5].Value.ToString();

                //    string imagepath = row.Cells[6].Value.ToString();

                //    try
                //    {
                //        if (imagepath != null)
                //        {
                //            addProducts_imageView.Image = Image.FromFile(imagepath);
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Error image :" + ex, "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //    addProducts_status.Text = row.Cells[7].Value.ToString();
                string imagepath = row.Cells[6].Value.ToString();

                try
                {
                    if (addProducts_imageView.Image != null)
                    {
                        addProducts_imageView.Image.Dispose(); // Dispose old image if any
                        addProducts_imageView.Image = null;
                    }

                    if (!string.IsNullOrEmpty(imagepath) && File.Exists(imagepath))
                    {
                        using (FileStream fs = new FileStream(imagepath, FileMode.Open, FileAccess.Read))
                        {
                            addProducts_imageView.Image = Image.FromStream(fs);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to update this Product ID :" + addProducts_proID.Text.Trim() + "?",
                "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (EmptyFeilds())
                {
                    MessageBox.Show("Empty Fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();



                            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                            //string folderName = "Product_Directory";
                            //string fileName = addProducts_proID.Text.Trim() + ".jpg";

                            //string directoryPath = Path.Combine(baseDirectory, folderName);


                            //if (!Directory.Exists(directoryPath))
                            //{
                            //    Directory.CreateDirectory(directoryPath);
                            //}

                            //string fullPath = Path.Combine(directoryPath, fileName);


                            //if (!string.IsNullOrEmpty(addProducts_imageView.ImageLocation) && File.Exists(addProducts_imageView.ImageLocation))
                            //{
                            //    File.Copy(addProducts_imageView.ImageLocation, fullPath, true);
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Selected image file not found.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //    return;
                            //}


                            string updateData = "UPDATE products SET prod_id =@prodID ,prod_name=@prodName, category = @cat," +
                                "price=@price ,stock =@stock,image_path =@path, status =@status WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.Parameters.AddWithValue("@prodID", addProducts_proID.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodName", addProducts_proName.Text.Trim());
                                updateD.Parameters.AddWithValue("@cat", addProducts_category.Text.Trim());
                                updateD.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                //updateD.Parameters.AddWithValue("@path", fullPath);
                                updateD.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                //updateD.Parameters.AddWithValue("@status", addProducts_status.Text.Trim());

                                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                                string folderName = "Product_Directory";
                                string fileName = addProducts_proID.Text.Trim() + ".jpg";

                                string directoryPath = Path.Combine(baseDirectory, folderName);


                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                string fullPath = Path.Combine(directoryPath, fileName);


                                //if (!string.IsNullOrEmpty(addProducts_imageView.ImageLocation) && File.Exists(addProducts_imageView.ImageLocation))
                                //{
                                //    File.Copy(addProducts_imageView.ImageLocation, fullPath, true);
                                //}
                                if (addProducts_imageView.Image != null)
                                {
                                    addProducts_imageView.Image.Dispose();
                                    addProducts_imageView.Image = null;
                                }

                                else
                                {
                                    MessageBox.Show("Selected image file not found.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                updateD.Parameters.AddWithValue("@path ", fullPath);
                                updateD.Parameters.AddWithValue("@status ", addProducts_status.SelectedItem);



                                DateTime Today = DateTime.Today;
                                updateD.Parameters.AddWithValue("@date", Today);

                                updateD.ExecuteNonQuery();
                                clearFeilds();
                                displayAllProducts();
                                MessageBox.Show("Added successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed Connection: " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }

                }



            }
        }

        private void addProducts_rmvBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Delete this Product ID :" + addProducts_proID.Text.Trim() + "?",
                "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (EmptyFeilds())
                {
                    MessageBox.Show("Empty Fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();



                            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                            //string folderName = "Product_Directory";
                            //string fileName = addProducts_proID.Text.Trim() + ".jpg";

                            //string directoryPath = Path.Combine(baseDirectory, folderName);


                            //if (!Directory.Exists(directoryPath))
                            //{
                            //    Directory.CreateDirectory(directoryPath);
                            //}

                            //string fullPath = Path.Combine(directoryPath, fileName);


                            //if (!string.IsNullOrEmpty(addProducts_imageView.ImageLocation) && File.Exists(addProducts_imageView.ImageLocation))
                            //{
                            //    File.Copy(addProducts_imageView.ImageLocation, fullPath, true);
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Selected image file not found.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //    return;
                            //}


                            string deleteData = "DELETE FROM products WHERE id = @id";

                            using (SqlCommand deleteD = new SqlCommand(deleteData, connect))
                            {
                                deleteD.Parameters.AddWithValue("@id", getID);

                                //updateD.Parameters.AddWithValue("@prodID", addProducts_proID.Text.Trim());
                                //updateD.Parameters.AddWithValue("@prodName", addProducts_proName.Text.Trim());
                                //updateD.Parameters.AddWithValue("@cat", addProducts_category.Text.Trim());
                                //updateD.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                ////updateD.Parameters.AddWithValue("@path", fullPath);
                                //updateD.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                ////updateD.Parameters.AddWithValue("@status", addProducts_status.Text.Trim());

                                //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                                //string folderName = "Product_Directory";
                                //string fileName = addProducts_proID.Text.Trim() + ".jpg";

                                //string directoryPath = Path.Combine(baseDirectory, folderName);


                                //if (!Directory.Exists(directoryPath))
                                //{
                                //    Directory.CreateDirectory(directoryPath);
                                //}

                                //string fullPath = Path.Combine(directoryPath, fileName);


                                //if (!string.IsNullOrEmpty(addProducts_imageView.ImageLocation) && File.Exists(addProducts_imageView.ImageLocation))
                                //{
                                //    File.Copy(addProducts_imageView.ImageLocation, fullPath, true);
                                //}
                                //if (addProducts_imageView.Image != null)
                                //{
                                //    addProducts_imageView.Image.Dispose();
                                //    addProducts_imageView.Image = null;
                                //}

                                //else
                                //{
                                //    MessageBox.Show("Selected image file not found.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //    return;
                                //}

                                //updateD.Parameters.AddWithValue("@path ", fullPath);
                                //updateD.Parameters.AddWithValue("@status ", addProducts_status.SelectedItem);



                                //DateTime Today = DateTime.Today;
                                //updateD.Parameters.AddWithValue("@date", Today);

                                deleteD.ExecuteNonQuery();
                                clearFeilds();
                                displayAllProducts();
                                MessageBox.Show("Delete successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed Connection: " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
