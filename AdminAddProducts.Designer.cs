namespace Invetory_Management_System
{
    partial class AdminAddProducts
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            addProducts_ClearBtn = new Button();
            addProducts_rmvBtn = new Button();
            addProducts_updateBtn = new Button();
            addProducts_addBtn = new Button();
            addProducts_importBtn = new Button();
            panel3 = new Panel();
            addProducts_imageView = new PictureBox();
            addProducts_status = new ComboBox();
            label7 = new Label();
            addProducts_stock = new TextBox();
            label6 = new Label();
            addProducts_price = new TextBox();
            label5 = new Label();
            addProducts_category = new ComboBox();
            label4 = new Label();
            addProducts_proName = new TextBox();
            label3 = new Label();
            addProducts_proID = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addProducts_imageView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 329);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(959, 277);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 1;
            label1.Text = "All Products ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(addProducts_ClearBtn);
            panel2.Controls.Add(addProducts_rmvBtn);
            panel2.Controls.Add(addProducts_updateBtn);
            panel2.Controls.Add(addProducts_addBtn);
            panel2.Controls.Add(addProducts_importBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(addProducts_status);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(addProducts_stock);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addProducts_price);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addProducts_category);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addProducts_proName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addProducts_proID);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Microsoft Sans Serif", 10.8F);
            panel2.Location = new Point(12, 367);
            panel2.Name = "panel2";
            panel2.Size = new Size(965, 264);
            panel2.TabIndex = 1;
            // 
            // addProducts_ClearBtn
            // 
            addProducts_ClearBtn.BackColor = Color.FromArgb(85, 113, 73);
            addProducts_ClearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            addProducts_ClearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            addProducts_ClearBtn.FlatStyle = FlatStyle.Flat;
            addProducts_ClearBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            addProducts_ClearBtn.ForeColor = Color.White;
            addProducts_ClearBtn.Location = new Point(636, 206);
            addProducts_ClearBtn.Name = "addProducts_ClearBtn";
            addProducts_ClearBtn.Size = new Size(97, 35);
            addProducts_ClearBtn.TabIndex = 17;
            addProducts_ClearBtn.Text = "Clear";
            addProducts_ClearBtn.UseVisualStyleBackColor = false;
            addProducts_ClearBtn.Click += addProducts_ClearBtn_Click;
            // 
            // addProducts_rmvBtn
            // 
            addProducts_rmvBtn.BackColor = Color.FromArgb(85, 113, 73);
            addProducts_rmvBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            addProducts_rmvBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            addProducts_rmvBtn.FlatStyle = FlatStyle.Flat;
            addProducts_rmvBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            addProducts_rmvBtn.ForeColor = Color.White;
            addProducts_rmvBtn.Location = new Point(496, 206);
            addProducts_rmvBtn.Name = "addProducts_rmvBtn";
            addProducts_rmvBtn.Size = new Size(97, 35);
            addProducts_rmvBtn.TabIndex = 16;
            addProducts_rmvBtn.Text = "Remove";
            addProducts_rmvBtn.UseVisualStyleBackColor = false;
            addProducts_rmvBtn.Click += addProducts_rmvBtn_Click;
            // 
            // addProducts_updateBtn
            // 
            addProducts_updateBtn.BackColor = Color.FromArgb(85, 113, 73);
            addProducts_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            addProducts_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            addProducts_updateBtn.FlatStyle = FlatStyle.Flat;
            addProducts_updateBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            addProducts_updateBtn.ForeColor = Color.White;
            addProducts_updateBtn.Location = new Point(296, 206);
            addProducts_updateBtn.Name = "addProducts_updateBtn";
            addProducts_updateBtn.Size = new Size(97, 35);
            addProducts_updateBtn.TabIndex = 15;
            addProducts_updateBtn.Text = "Update";
            addProducts_updateBtn.UseVisualStyleBackColor = false;
            addProducts_updateBtn.Click += addProducts_updateBtn_Click;
            // 
            // addProducts_addBtn
            // 
            addProducts_addBtn.BackColor = Color.FromArgb(85, 113, 73);
            addProducts_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            addProducts_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            addProducts_addBtn.FlatStyle = FlatStyle.Flat;
            addProducts_addBtn.Font = new Font("Microsoft Sans Serif", 10.2F);
            addProducts_addBtn.ForeColor = Color.White;
            addProducts_addBtn.Location = new Point(156, 206);
            addProducts_addBtn.Name = "addProducts_addBtn";
            addProducts_addBtn.Size = new Size(97, 35);
            addProducts_addBtn.TabIndex = 14;
            addProducts_addBtn.Text = "Add";
            addProducts_addBtn.UseVisualStyleBackColor = false;
            addProducts_addBtn.Click += addProducts_addBtn_Click;
            // 
            // addProducts_importBtn
            // 
            addProducts_importBtn.BackColor = Color.FromArgb(85, 113, 73);
            addProducts_importBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            addProducts_importBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            addProducts_importBtn.FlatStyle = FlatStyle.Flat;
            addProducts_importBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_importBtn.ForeColor = Color.White;
            addProducts_importBtn.Location = new Point(845, 141);
            addProducts_importBtn.Name = "addProducts_importBtn";
            addProducts_importBtn.Size = new Size(97, 32);
            addProducts_importBtn.TabIndex = 13;
            addProducts_importBtn.Text = "Import";
            addProducts_importBtn.UseVisualStyleBackColor = false;
            addProducts_importBtn.Click += addProducts_importBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(addProducts_imageView);
            panel3.Location = new Point(845, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(97, 94);
            panel3.TabIndex = 12;
            // 
            // addProducts_imageView
            // 
            addProducts_imageView.Location = new Point(0, 0);
            addProducts_imageView.Name = "addProducts_imageView";
            addProducts_imageView.Size = new Size(97, 94);
            addProducts_imageView.SizeMode = PictureBoxSizeMode.StretchImage;
            addProducts_imageView.TabIndex = 0;
            addProducts_imageView.TabStop = false;
            // 
            // addProducts_status
            // 
            addProducts_status.FormattingEnabled = true;
            addProducts_status.Items.AddRange(new object[] { "Available", "Not available" });
            addProducts_status.Location = new Point(517, 103);
            addProducts_status.Name = "addProducts_status";
            addProducts_status.Size = new Size(198, 30);
            addProducts_status.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(441, 103);
            label7.Name = "label7";
            label7.Size = new Size(71, 22);
            label7.TabIndex = 10;
            label7.Text = "Status :";
            // 
            // addProducts_stock
            // 
            addProducts_stock.BorderStyle = BorderStyle.FixedSingle;
            addProducts_stock.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_stock.Location = new Point(518, 65);
            addProducts_stock.Name = "addProducts_stock";
            addProducts_stock.Size = new Size(197, 24);
            addProducts_stock.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(452, 67);
            label6.Name = "label6";
            label6.Size = new Size(60, 22);
            label6.TabIndex = 8;
            label6.Text = "Stock:";
            // 
            // addProducts_price
            // 
            addProducts_price.BorderStyle = BorderStyle.FixedSingle;
            addProducts_price.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_price.Location = new Point(516, 23);
            addProducts_price.Name = "addProducts_price";
            addProducts_price.Size = new Size(199, 24);
            addProducts_price.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(402, 22);
            label5.Name = "label5";
            label5.Size = new Size(110, 22);
            label5.TabIndex = 6;
            label5.Text = "Price (BDT):";
            // 
            // addProducts_category
            // 
            addProducts_category.FormattingEnabled = true;
            addProducts_category.Location = new Point(169, 120);
            addProducts_category.Name = "addProducts_category";
            addProducts_category.Size = new Size(198, 30);
            addProducts_category.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 121);
            label4.Name = "label4";
            label4.Size = new Size(93, 22);
            label4.TabIndex = 4;
            label4.Text = "Category :";
            // 
            // addProducts_proName
            // 
            addProducts_proName.BorderStyle = BorderStyle.FixedSingle;
            addProducts_proName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_proName.Location = new Point(169, 68);
            addProducts_proName.Name = "addProducts_proName";
            addProducts_proName.Size = new Size(198, 24);
            addProducts_proName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 70);
            label3.Name = "label3";
            label3.Size = new Size(134, 22);
            label3.TabIndex = 2;
            label3.Text = "Product Name :";
            // 
            // addProducts_proID
            // 
            addProducts_proID.BorderStyle = BorderStyle.FixedSingle;
            addProducts_proID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_proID.Location = new Point(169, 23);
            addProducts_proID.Name = "addProducts_proID";
            addProducts_proID.Size = new Size(156, 24);
            addProducts_proID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 25);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 0;
            label2.Text = "Product ID:";
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddProducts";
            Size = new Size(989, 654);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addProducts_imageView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox addProducts_proName;
        private Label label3;
        private TextBox addProducts_proID;
        private Label label2;
        private Panel panel3;
        private ComboBox addProducts_status;
        private Label label7;
        private TextBox addProducts_stock;
        private Label label6;
        private TextBox addProducts_price;
        private Label label5;
        private ComboBox addProducts_category;
        private Label label4;
        private Button addProducts_updateBtn;
        private Button addProducts_addBtn;
        private Button addProducts_importBtn;
        private PictureBox addProducts_imageView;
        private Button addProducts_ClearBtn;
        private Button addProducts_rmvBtn;
        private DataGridView dataGridView1;
    }
}
