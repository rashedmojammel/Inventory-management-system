namespace Invetory_Management_System
{
    partial class CashierOrder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrder));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            cashierOrder_ClearBtn = new Button();
            cashierOrder_price = new Label();
            label8 = new Label();
            cashierOrder_removeBtn = new Button();
            cashierOrder_addBtn = new Button();
            cashierOrder_qty = new NumericUpDown();
            label6 = new Label();
            cashierOrder_prodName = new Label();
            label4 = new Label();
            label3 = new Label();
            cashierOrder_prodID = new ComboBox();
            label2 = new Label();
            cashierOrder_Category = new ComboBox();
            panel3 = new Panel();
            cashierOrder_Recipt = new Button();
            cashierOrder_payOrder = new Button();
            cashierOrder_change = new Label();
            label7 = new Label();
            cashierOrder_amount = new TextBox();
            label12 = new Label();
            label11 = new Label();
            cashierOrder_totalPrice = new Label();
            label10 = new Label();
            dataGridView3 = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrder_qty).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 307);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 113, 73);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(85, 113, 73);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(619, 246);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(651, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(295, 247);
            dataGridView2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 1;
            label1.Text = "Available Products";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cashierOrder_ClearBtn);
            panel2.Controls.Add(cashierOrder_price);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cashierOrder_removeBtn);
            panel2.Controls.Add(cashierOrder_addBtn);
            panel2.Controls.Add(cashierOrder_qty);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cashierOrder_prodName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cashierOrder_prodID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cashierOrder_Category);
            panel2.Location = new Point(15, 327);
            panel2.Name = "panel2";
            panel2.Size = new Size(642, 312);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 15);
            label5.Name = "label5";
            label5.Size = new Size(179, 20);
            label5.TabIndex = 16;
            label5.Text = "Select your products";
            // 
            // cashierOrder_ClearBtn
            // 
            cashierOrder_ClearBtn.BackColor = Color.FromArgb(85, 113, 73);
            cashierOrder_ClearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            cashierOrder_ClearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            cashierOrder_ClearBtn.FlatStyle = FlatStyle.Flat;
            cashierOrder_ClearBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            cashierOrder_ClearBtn.ForeColor = Color.White;
            cashierOrder_ClearBtn.Location = new Point(464, 255);
            cashierOrder_ClearBtn.Name = "cashierOrder_ClearBtn";
            cashierOrder_ClearBtn.Size = new Size(97, 35);
            cashierOrder_ClearBtn.TabIndex = 21;
            cashierOrder_ClearBtn.Text = "Clear";
            cashierOrder_ClearBtn.UseVisualStyleBackColor = false;
            cashierOrder_ClearBtn.Click += cashierOrder_ClearBtn_Click;
            // 
            // cashierOrder_price
            // 
            cashierOrder_price.AutoSize = true;
            cashierOrder_price.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_price.Location = new Point(155, 202);
            cashierOrder_price.Name = "cashierOrder_price";
            cashierOrder_price.Size = new Size(96, 20);
            cashierOrder_price.TabIndex = 9;
            cashierOrder_price.Text = "Category :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(49, 202);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 8;
            label8.Text = "Price(BDT):";
            // 
            // cashierOrder_removeBtn
            // 
            cashierOrder_removeBtn.BackColor = Color.FromArgb(85, 113, 73);
            cashierOrder_removeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            cashierOrder_removeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            cashierOrder_removeBtn.FlatStyle = FlatStyle.Flat;
            cashierOrder_removeBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            cashierOrder_removeBtn.ForeColor = Color.White;
            cashierOrder_removeBtn.Location = new Point(216, 255);
            cashierOrder_removeBtn.Name = "cashierOrder_removeBtn";
            cashierOrder_removeBtn.Size = new Size(97, 35);
            cashierOrder_removeBtn.TabIndex = 19;
            cashierOrder_removeBtn.Text = "Remove";
            cashierOrder_removeBtn.UseVisualStyleBackColor = false;
            cashierOrder_removeBtn.Click += cashierOrder_removeBtn_Click;
            // 
            // cashierOrder_addBtn
            // 
            cashierOrder_addBtn.BackColor = Color.FromArgb(85, 113, 73);
            cashierOrder_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            cashierOrder_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            cashierOrder_addBtn.FlatStyle = FlatStyle.Flat;
            cashierOrder_addBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            cashierOrder_addBtn.ForeColor = Color.White;
            cashierOrder_addBtn.Location = new Point(76, 255);
            cashierOrder_addBtn.Name = "cashierOrder_addBtn";
            cashierOrder_addBtn.Size = new Size(97, 35);
            cashierOrder_addBtn.TabIndex = 18;
            cashierOrder_addBtn.Text = "Add";
            cashierOrder_addBtn.UseVisualStyleBackColor = false;
            cashierOrder_addBtn.Click += cashierOrder_addBtn_Click;
            // 
            // cashierOrder_qty
            // 
            cashierOrder_qty.Location = new Point(421, 113);
            cashierOrder_qty.Name = "cashierOrder_qty";
            cashierOrder_qty.Size = new Size(156, 27);
            cashierOrder_qty.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(330, 115);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 6;
            label6.Text = "Quantity:";
            // 
            // cashierOrder_prodName
            // 
            cashierOrder_prodName.AutoSize = true;
            cashierOrder_prodName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_prodName.Location = new Point(155, 155);
            cashierOrder_prodName.Name = "cashierOrder_prodName";
            cashierOrder_prodName.Size = new Size(96, 20);
            cashierOrder_prodName.TabIndex = 5;
            cashierOrder_prodName.Text = "Category :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 155);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 4;
            label4.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(314, 68);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 3;
            label3.Text = "Product Id:";
            // 
            // cashierOrder_prodID
            // 
            cashierOrder_prodID.FormattingEnabled = true;
            cashierOrder_prodID.Location = new Point(421, 65);
            cashierOrder_prodID.Name = "cashierOrder_prodID";
            cashierOrder_prodID.Size = new Size(161, 28);
            cashierOrder_prodID.TabIndex = 2;
            cashierOrder_prodID.SelectedIndexChanged += cashierOrder_prodID_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 68);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Category:";
            // 
            // cashierOrder_Category
            // 
            cashierOrder_Category.FormattingEnabled = true;
            cashierOrder_Category.Location = new Point(128, 65);
            cashierOrder_Category.Name = "cashierOrder_Category";
            cashierOrder_Category.Size = new Size(151, 28);
            cashierOrder_Category.TabIndex = 0;
            cashierOrder_Category.SelectedIndexChanged += cashierOrder_Category_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cashierOrder_Recipt);
            panel3.Controls.Add(cashierOrder_payOrder);
            panel3.Controls.Add(cashierOrder_change);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(cashierOrder_amount);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(cashierOrder_totalPrice);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(dataGridView3);
            panel3.Location = new Point(663, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 625);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // cashierOrder_Recipt
            // 
            cashierOrder_Recipt.BackColor = Color.FromArgb(85, 113, 73);
            cashierOrder_Recipt.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            cashierOrder_Recipt.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            cashierOrder_Recipt.FlatStyle = FlatStyle.Flat;
            cashierOrder_Recipt.Font = new Font("Microsoft Sans Serif", 10.2F);
            cashierOrder_Recipt.ForeColor = Color.White;
            cashierOrder_Recipt.Location = new Point(18, 568);
            cashierOrder_Recipt.Name = "cashierOrder_Recipt";
            cashierOrder_Recipt.Size = new Size(289, 35);
            cashierOrder_Recipt.TabIndex = 29;
            cashierOrder_Recipt.Text = "Recipt";
            cashierOrder_Recipt.UseVisualStyleBackColor = false;
            cashierOrder_Recipt.Click += cashierOrder_Recipt_Click;
            // 
            // cashierOrder_payOrder
            // 
            cashierOrder_payOrder.BackColor = Color.FromArgb(85, 113, 73);
            cashierOrder_payOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            cashierOrder_payOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            cashierOrder_payOrder.FlatStyle = FlatStyle.Flat;
            cashierOrder_payOrder.Font = new Font("Microsoft Sans Serif", 10.2F);
            cashierOrder_payOrder.ForeColor = Color.White;
            cashierOrder_payOrder.Location = new Point(18, 508);
            cashierOrder_payOrder.Name = "cashierOrder_payOrder";
            cashierOrder_payOrder.Size = new Size(289, 35);
            cashierOrder_payOrder.TabIndex = 28;
            cashierOrder_payOrder.Text = "Pay orders";
            cashierOrder_payOrder.UseVisualStyleBackColor = false;
            cashierOrder_payOrder.Click += cashierOrder_payOrder_Click;
            // 
            // cashierOrder_change
            // 
            cashierOrder_change.AutoSize = true;
            cashierOrder_change.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_change.ForeColor = Color.Black;
            cashierOrder_change.Location = new Point(155, 439);
            cashierOrder_change.Name = "cashierOrder_change";
            cashierOrder_change.Size = new Size(44, 20);
            cashierOrder_change.TabIndex = 27;
            cashierOrder_change.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(84, 439);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 26;
            label7.Text = "Change:";
            // 
            // cashierOrder_amount
            // 
            cashierOrder_amount.BorderStyle = BorderStyle.FixedSingle;
            cashierOrder_amount.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_amount.Location = new Point(159, 394);
            cashierOrder_amount.Name = "cashierOrder_amount";
            cashierOrder_amount.Size = new Size(139, 27);
            cashierOrder_amount.TabIndex = 25;
            cashierOrder_amount.KeyDown += cashierOrder_amount_KeyDown;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(32, 396);
            label12.Name = "label12";
            label12.Size = new Size(130, 20);
            label12.TabIndex = 24;
            label12.Text = "Amount(BDT):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(14, 16);
            label11.Name = "label11";
            label11.Size = new Size(92, 20);
            label11.TabIndex = 16;
            label11.Text = "All Orders";
            // 
            // cashierOrder_totalPrice
            // 
            cashierOrder_totalPrice.AutoSize = true;
            cashierOrder_totalPrice.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_totalPrice.Location = new Point(155, 352);
            cashierOrder_totalPrice.Name = "cashierOrder_totalPrice";
            cashierOrder_totalPrice.Size = new Size(44, 20);
            cashierOrder_totalPrice.TabIndex = 23;
            cashierOrder_totalPrice.Text = "0.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 352);
            label10.Name = "label10";
            label10.Size = new Size(159, 20);
            label10.TabIndex = 22;
            label10.Text = "Total Price(BDT):";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(85, 113, 73);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(85, 113, 73);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView3.Location = new Point(14, 49);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(293, 246);
            dataGridView3.TabIndex = 16;
            dataGridView3.CellClick += dataGridView3_CellClick;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // CashierOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CashierOrder";
            Size = new Size(989, 654);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrder_qty).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox cashierOrder_Category;
        private DataGridView dataGridView3;
        private Label label4;
        private Label label3;
        private ComboBox cashierOrder_prodID;
        private NumericUpDown cashierOrder_qty;
        private Label label6;
        private Label cashierOrder_prodName;
        private Label cashierOrder_price;
        private Label label8;
        private Button cashierOrder_ClearBtn;
        private Button cashierOrder_removeBtn;
        private Button cashierOrder_addBtn;
        private Label cashierOrder_totalPrice;
        private Label label10;
        private TextBox cashierOrder_amount;
        private Label label12;
        private Label label11;
        private Button cashierOrder_Recipt;
        private Button cashierOrder_payOrder;
        private Label cashierOrder_change;
        private Label label7;
        private Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
