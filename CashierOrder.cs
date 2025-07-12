using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
namespace Invetory_Management_System
{
    public partial class CashierOrder : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False");
        public CashierOrder()
        {
            InitializeComponent();
            displayAllAvailableProducts();
            displayAllCatagories();

            displayOrders();
            displayTotalPrice();
        }

        public void displayAllAvailableProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.allaAvailableproductsData();

            dataGridView1.DataSource = listData;

        }
        public void displayOrders()
        {
            OrdersData oData = new OrdersData();
            List<OrdersData> listData = oData.allOrdersData();

            dataGridView3.DataSource = listData;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
        
        public void displayAllCatagories()
        {
            try
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cashierOrder_Category.Items.Clear();

                        while (reader.Read())
                        {
                            string item = reader.GetString(1); // Assuming second column is category name
                            cashierOrder_Category.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load categories: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }


        private void cashierOrder_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodID.Items.Clear();
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
            cashierOrder_qty.Value = 0;
            string selectedvalue = cashierOrder_Category.SelectedItem as string;

            if (selectedvalue != null)
            {
                try
                {
                    connect.Open();

                    string selectData = $"SELECT * FROM products WHERE category = '{selectedvalue}' AND status =@status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", selectedvalue);
                        cmd.Parameters.AddWithValue("@status", "Available");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string value = reader["prod_id"].ToString();
                                cashierOrder_prodID.Items.Add(value);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection :" + ex, "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();

                }
            }
        }

        private void cashierOrder_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashierOrder_prodID.SelectedItem as string;

            if (checkConnection())
            {
                if (selectedValue != null)
                {
                    try
                    {
                        connect.Open();

                        string selectData = $"SELECT * FROM products WHERE prod_id ='{selectedValue}' AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["prod_name"].ToString();
                                    float prodPrice = Convert.ToSingle(reader["price"]);


                                    cashierOrder_prodName.Text = prodName;
                                    cashierOrder_price.Text = prodPrice.ToString("0.00");
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private float totalPrice = 0;
        public void displayTotalPrice()
        {
            IDGenerator();

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(total_price) FROM orders WHERE customer_id = @cID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", idGen);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);

                            cashierOrder_totalPrice.Text = totalPrice.ToString("0.00");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed :" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();

                }
            }

        }

        private void cashierOrder_addBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (cashierOrder_Category.SelectedIndex == -1 || cashierOrder_prodID.SelectedIndex == -1 ||
                cashierOrder_prodName.Text == "" || cashierOrder_price.Text == "" || cashierOrder_qty.Value == 0)
            {
                MessageBox.Show("Please select the item first ", "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM products WHERE prod_id = @proID";

                        using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                        {
                            getOrder.Parameters.AddWithValue("@proID", cashierOrder_prodID.SelectedItem);

                            using (SqlDataReader reader = getOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["price"];

                                    if (rawValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToSingle(rawValue);


                                    }

                                }

                            }
                        }

                        string insertData = "INSERT INTO orders(customer_id,prod_id,prod_name,category,qty,orig_price,total_price,order_date) " +
                    "VALUES(@cId,@proID,@prodName,@cat,@qty,@origPrice,@totalprice,@date)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cId", idGen);
                            cmd.Parameters.AddWithValue("@proID", cashierOrder_prodID.SelectedItem);
                            cmd.Parameters.AddWithValue("@prodName", cashierOrder_prodName.Text.Trim());
                            cmd.Parameters.AddWithValue("@cat", cashierOrder_Category.SelectedItem);
                            cmd.Parameters.AddWithValue("@qty", cashierOrder_qty.Value);
                            cmd.Parameters.AddWithValue("@origPrice", getPrice);

                            float totalP = getPrice * (int)cashierOrder_qty.Value;
                            cmd.Parameters.AddWithValue("@totalprice", totalP);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);

                            //int result = cmd.ExecuteNonQuery();
                            //MessageBox.Show("Rows affected: " + result);

                            cmd.ExecuteNonQuery();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection :" + ex, "Error message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();

                    }
                }

            }

            displayOrders();
            displayTotalPrice();
        }

        private int idGen;
        public void IDGenerator()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False"))
            {
                connect.Open();

                string selectData = "SELECT MAX(customer_id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        int temp = Convert.ToInt32(result);
                        idGen = temp + 1; // Always get next available ID
                    }
                    else
                    {
                        idGen = 1; // First customer
                    }

                }
            }
        }
        //public void IDGenerator()
        //{
        //    using (SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False"))
        //    {
        //        connect.Open();

        //        string selectData = "SELECT MAX(customer_id) FROM customers";

        //        using (SqlCommand cmd = new SqlCommand(selectData, connect))
        //        {
        //            object result = cmd.ExecuteScalar();

        //            if (result != DBNull.Value && result != null)
        //            {
        //                int temp = Convert.ToInt32(result);
        //                idGen = temp + 1;
        //            }
        //            else
        //            {
        //                idGen = 1; // First customer
        //            }
        //        }
        //    }
        //}
        private void cashierOrder_removeBtn_Click(object sender, EventArgs e)
        {
            if (proID == 0)
            {
                MessageBox.Show("Please select the item first", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Are you sure you want to remove ID :" + proID
                    + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM orders WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", proID);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Removed succesfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed Connection :" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            connect.Close();

                        }
                    }
                }
            }

            displayOrders();
            displayTotalPrice();


        }

        private int proID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
            proID = (int)row.Cells[0].Value;

        }

        public void clearFeilds()
        {
            cashierOrder_Category.SelectedIndex = -1;
            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
            cashierOrder_qty.Value = 0;
        }
        private void cashierOrder_ClearBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void cashierOrder_payOrder_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (cashierOrder_amount.Text == "" || dataGridView3.Rows.Count < 0)
            {
                MessageBox.Show("Something went wrong", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure to pay your orders?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string insertData = "INSERT INTO customers (customer_id,total_price,amount,change,order_Date)" +
                                "VALUES(@cID,@totalPrice,@amount,@change,@date)";
                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@cID", idGen);
                                //cmd.Parameters.AddWithValue("@proID", cashierOrder_prodID.SelectedItem);
                                cmd.Parameters.AddWithValue("@totalPrice", cashierOrder_totalPrice.Text);
                                cmd.Parameters.AddWithValue("@amount", cashierOrder_amount.Text);
                                cmd.Parameters.AddWithValue("@change", cashierOrder_change.Text);


                                DateTime today = DateTime.Today;

                                cmd.Parameters.AddWithValue("@date", today);
                                cmd.ExecuteNonQuery();
                                clearFeilds();
                                MessageBox.Show("Paid succesfully ", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed :" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
            displayTotalPrice();

        }

        private void cashierOrder_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(cashierOrder_amount.Text);
                    float getChange = (getAmount - totalPrice);

                    if (getChange < 0)
                    {
                        MessageBox.Show("Insufficient payment!");
                        cashierOrder_change.Text = "";
                    }
                    else
                    {
                        cashierOrder_change.Text = getChange.ToString("0.00");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong :3", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cashierOrder_amount.Text = "";
                    cashierOrder_change.Text = "";
                }

            }
        }
        private int rowIndex = 0;
        private void cashierOrder_Recipt_Click(object sender, EventArgs e)
        {
            if(cashierOrder_amount.Text == "" || dataGridView3.Rows.Count<0)
            {
                MessageBox.Show("Please order first", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

            }

                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            displayTotalPrice();

            float y = 0;
            int count = 0;
            int colWidth = 115;
            int headerMargin = 8;
            int tableMargin = 8;

            Font font = new Font("Tahoma", 12);
            Font bold = new Font("tahoma", 12, FontStyle.Bold);
            Font headerFont = new Font("Tahoma", 16, FontStyle.Bold);
            Font labelFont = new Font("Tahoma", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "Al Taqdeer shop";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left +(dataGridView3.ColumnCount/2 )*colWidth,y,alignCenter);

            count++;
            y += tableMargin;

            string[] header = { "ID","CID","PName","Category","OrigPrice","QTY","TotalPrice"};

            for(int q = 0; q<header.Length; q++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[q], bold, Brushes.Black, e.MarginBounds.Left + q * colWidth,y,alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while(rowIndex < dataGridView3.Rows.Count)
            {
                DataGridViewRow row = dataGridView3.Rows[rowIndex];

                for (int q = 0; q < dataGridView3.Columns.Count; q++)
                {
                    object cellValue = row.Cells[q].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if(y + font.GetHeight(e.Graphics)>e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

            }

            int labelmargin = (int)Math.Min(rSpace, 200);

            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("--------------------------",labelFont).Width;

            y = e.MarginBounds.Bottom - labelmargin - labelFont.GetHeight(e.Graphics);

            e.Graphics.DrawString("Total price : \tBDT" + totalPrice + "\nAmount :\tBDT" + cashierOrder_amount.Text.Trim()
                + "\n\t\t-----------------\nChange : \tBDT" + cashierOrder_change.Text.Trim(), labelFont, Brushes.Black, labelX, y);

            labelmargin = (int)Math.Min(rSpace, -40);

            string labelTest = today.ToString();
            y = e.MarginBounds.Bottom - labelmargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelTest, labelFont, Brushes.Black, e.MarginBounds.Right - 
                e.Graphics.MeasureString("-------------------------",labelFont).Width,y);
        }
    }
}
