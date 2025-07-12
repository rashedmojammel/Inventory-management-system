namespace Invetory_Management_System
{
    partial class CashierMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMainForm));
            panel1 = new Panel();
            close = new Button();
            label1 = new Label();
            panel2 = new Panel();
            customers_btn = new Button();
            addproducts_btn = new Button();
            cashier_logout = new Button();
            order_btn = new Button();
            dashboard_btn = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            adminDashboard1 = new adminDashboard();
            adminAddProducts1 = new AdminAddProducts();
            cashierCustomerForm1 = new CashierCustomerForm();
            cashierOrder1 = new CashierOrder();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(close);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 46);
            panel1.TabIndex = 1;
            // 
            // close
            // 
            close.BackColor = Color.Firebrick;
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(1164, 9);
            close.Name = "close";
            close.Size = new Size(33, 29);
            close.TabIndex = 2;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(437, 21);
            label1.TabIndex = 1;
            label1.Text = "Inventory management system | Cashier's portal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(85, 113, 73);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(customers_btn);
            panel2.Controls.Add(addproducts_btn);
            panel2.Controls.Add(cashier_logout);
            panel2.Controls.Add(order_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 671);
            panel2.TabIndex = 2;
            // 
            // customers_btn
            // 
            customers_btn.FlatAppearance.BorderSize = 0;
            customers_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            customers_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customers_btn.ForeColor = Color.White;
            customers_btn.Location = new Point(94, 360);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(102, 36);
            customers_btn.TabIndex = 20;
            customers_btn.Text = "Customers";
            customers_btn.UseVisualStyleBackColor = true;
            customers_btn.Click += customers_btn_Click;
            // 
            // addproducts_btn
            // 
            addproducts_btn.FlatAppearance.BorderSize = 0;
            addproducts_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            addproducts_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            addproducts_btn.FlatStyle = FlatStyle.Flat;
            addproducts_btn.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addproducts_btn.ForeColor = Color.White;
            addproducts_btn.Location = new Point(94, 267);
            addproducts_btn.Name = "addproducts_btn";
            addproducts_btn.Size = new Size(104, 53);
            addproducts_btn.TabIndex = 19;
            addproducts_btn.Text = "Add products";
            addproducts_btn.UseVisualStyleBackColor = true;
            addproducts_btn.Click += addproducts_btn_Click;
            // 
            // cashier_logout
            // 
            cashier_logout.BackColor = Color.FromArgb(117, 145, 105);
            cashier_logout.FlatAppearance.BorderSize = 0;
            cashier_logout.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 113, 73);
            cashier_logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 113, 73);
            cashier_logout.FlatStyle = FlatStyle.Flat;
            cashier_logout.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashier_logout.ForeColor = Color.White;
            cashier_logout.Location = new Point(30, 613);
            cashier_logout.Name = "cashier_logout";
            cashier_logout.Size = new Size(148, 36);
            cashier_logout.TabIndex = 18;
            cashier_logout.Text = "Log out";
            cashier_logout.UseVisualStyleBackColor = false;
            cashier_logout.Click += cashier_logout_Click;
            // 
            // order_btn
            // 
            order_btn.FlatAppearance.BorderSize = 0;
            order_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            order_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            order_btn.FlatStyle = FlatStyle.Flat;
            order_btn.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_btn.ForeColor = Color.White;
            order_btn.Location = new Point(94, 448);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(96, 36);
            order_btn.TabIndex = 16;
            order_btn.Text = "Order";
            order_btn.UseVisualStyleBackColor = true;
            order_btn.Click += order_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(94, 197);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(102, 48);
            dashboard_btn.TabIndex = 10;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = true;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 122);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 8;
            label2.Text = "Welcome, Cashier";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.icons8_user_80px;
            pictureBox1.Location = new Point(65, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(adminDashboard1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(cashierCustomerForm1);
            panel3.Controls.Add(cashierOrder1);
            panel3.Location = new Point(217, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(989, 654);
            panel3.TabIndex = 3;
            // 
            // adminDashboard1
            // 
            adminDashboard1.Location = new Point(0, -6);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(1236, 818);
            adminDashboard1.TabIndex = 3;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(0, -13);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1236, 818);
            adminAddProducts1.TabIndex = 2;
            // 
            // cashierCustomerForm1
            // 
            cashierCustomerForm1.Location = new Point(-15, -6);
            cashierCustomerForm1.Name = "cashierCustomerForm1";
            cashierCustomerForm1.Size = new Size(1236, 818);
            cashierCustomerForm1.TabIndex = 1;
            // 
            // cashierOrder1
            // 
            cashierOrder1.Location = new Point(-15, -6);
            cashierOrder1.Name = "cashierOrder1";
            cashierOrder1.Size = new Size(1236, 818);
            cashierOrder1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 197);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(18, 262);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 58);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.None;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(18, 343);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(71, 53);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 431);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // CashierMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 717);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button close;
        private Label label1;
        private Panel panel2;
        private Button customers_btn;
        private Button addproducts_btn;
        private Button cashier_logout;
        private Button order_btn;
        private Button dashboard_btn;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private adminDashboard adminDashboard1;
        private AdminAddProducts adminAddProducts1;
        private CashierCustomerForm cashierCustomerForm1;
        private CashierOrder cashierOrder1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
    }
}