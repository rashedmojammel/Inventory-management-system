namespace Invetory_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            close = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            adminAddCatagories5 = new AdminAddCatagories();
            admin_logout = new Button();
            admin_customer = new Button();
            admin_addProducts = new Button();
            admin_addCatagories = new Button();
            admin_addUser = new Button();
            admin_Dashboard = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            adminViewDonations1 = new AdminViewDonations();
            cashierCustomerForm1 = new CashierCustomerForm();
            adminAddProducts1 = new AdminAddProducts();
            adminAddCatagories1 = new AdminAddCatagories();
            adminAddusers1 = new adminAddusers();
            adminDashboard1 = new adminDashboard();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox7 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(close);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 46);
            panel1.TabIndex = 0;
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
            label1.Size = new Size(424, 21);
            label1.TabIndex = 1;
            label1.Text = "Inventory management system | Admin's portal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(85, 113, 73);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(adminAddCatagories5);
            panel2.Controls.Add(admin_logout);
            panel2.Controls.Add(admin_customer);
            panel2.Controls.Add(admin_addProducts);
            panel2.Controls.Add(admin_addCatagories);
            panel2.Controls.Add(admin_addUser);
            panel2.Controls.Add(admin_Dashboard);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 654);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(93, 459);
            button1.Name = "button1";
            button1.Size = new Size(105, 49);
            button1.TabIndex = 25;
            button1.Text = "Donations";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.None;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(16, 389);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(71, 53);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(9, 325);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 58);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(7, 255);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(7, 182);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 67);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 128);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // adminAddCatagories5
            // 
            adminAddCatagories5.Location = new Point(200, 122);
            adminAddCatagories5.Name = "adminAddCatagories5";
            adminAddCatagories5.Size = new Size(1236, 818);
            adminAddCatagories5.TabIndex = 19;
            // 
            // admin_logout
            // 
            admin_logout.BackColor = Color.FromArgb(117, 145, 105);
            admin_logout.FlatAppearance.BorderSize = 0;
            admin_logout.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 113, 73);
            admin_logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 113, 73);
            admin_logout.FlatStyle = FlatStyle.Flat;
            admin_logout.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin_logout.ForeColor = SystemColors.Desktop;
            admin_logout.Location = new Point(30, 595);
            admin_logout.Name = "admin_logout";
            admin_logout.Size = new Size(148, 36);
            admin_logout.TabIndex = 18;
            admin_logout.Text = "Log out";
            admin_logout.UseVisualStyleBackColor = false;
            admin_logout.Click += admin_logout_Click;
            // 
            // admin_customer
            // 
            admin_customer.FlatAppearance.BorderSize = 0;
            admin_customer.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            admin_customer.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            admin_customer.FlatStyle = FlatStyle.Flat;
            admin_customer.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin_customer.ForeColor = Color.White;
            admin_customer.Location = new Point(93, 401);
            admin_customer.Name = "admin_customer";
            admin_customer.Size = new Size(105, 42);
            admin_customer.TabIndex = 17;
            admin_customer.Text = "Customers";
            admin_customer.UseVisualStyleBackColor = true;
            admin_customer.Click += admin_customer_Click;
            // 
            // admin_addProducts
            // 
            admin_addProducts.FlatAppearance.BorderSize = 0;
            admin_addProducts.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            admin_addProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            admin_addProducts.FlatStyle = FlatStyle.Flat;
            admin_addProducts.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin_addProducts.ForeColor = Color.White;
            admin_addProducts.Location = new Point(86, 325);
            admin_addProducts.Name = "admin_addProducts";
            admin_addProducts.Size = new Size(119, 58);
            admin_addProducts.TabIndex = 16;
            admin_addProducts.Text = "Add products";
            admin_addProducts.UseVisualStyleBackColor = true;
            admin_addProducts.Click += admin_addProducts_Click;
            // 
            // admin_addCatagories
            // 
            admin_addCatagories.FlatAppearance.BorderSize = 0;
            admin_addCatagories.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            admin_addCatagories.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            admin_addCatagories.FlatStyle = FlatStyle.Flat;
            admin_addCatagories.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin_addCatagories.ForeColor = Color.White;
            admin_addCatagories.Location = new Point(85, 255);
            admin_addCatagories.Name = "admin_addCatagories";
            admin_addCatagories.Size = new Size(118, 64);
            admin_addCatagories.TabIndex = 15;
            admin_addCatagories.Text = "Add catagories";
            admin_addCatagories.UseVisualStyleBackColor = true;
            admin_addCatagories.Click += admin_addCatagories_Click;
            // 
            // admin_addUser
            // 
            admin_addUser.FlatAppearance.BorderSize = 0;
            admin_addUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            admin_addUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            admin_addUser.FlatStyle = FlatStyle.Flat;
            admin_addUser.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin_addUser.ForeColor = Color.White;
            admin_addUser.Location = new Point(87, 191);
            admin_addUser.Name = "admin_addUser";
            admin_addUser.Size = new Size(119, 49);
            admin_addUser.TabIndex = 14;
            admin_addUser.Text = "Add users ";
            admin_addUser.UseVisualStyleBackColor = true;
            admin_addUser.Click += admin_addUser_Click;
            // 
            // admin_Dashboard
            // 
            admin_Dashboard.FlatAppearance.BorderSize = 0;
            admin_Dashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            admin_Dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            admin_Dashboard.FlatStyle = FlatStyle.Flat;
            admin_Dashboard.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin_Dashboard.ForeColor = Color.White;
            admin_Dashboard.Location = new Point(89, 122);
            admin_Dashboard.Name = "admin_Dashboard";
            admin_Dashboard.Size = new Size(108, 54);
            admin_Dashboard.TabIndex = 10;
            admin_Dashboard.Text = "Dashboard";
            admin_Dashboard.UseVisualStyleBackColor = true;
            admin_Dashboard.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 91);
            label2.Name = "label2";
            label2.Size = new Size(152, 22);
            label2.TabIndex = 8;
            label2.Text = "Welcome,Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.icons8_user_80px;
            pictureBox1.Location = new Point(65, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(adminViewDonations1);
            panel3.Controls.Add(cashierCustomerForm1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(adminAddCatagories1);
            panel3.Controls.Add(adminAddusers1);
            panel3.Controls.Add(adminDashboard1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(211, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(989, 654);
            panel3.TabIndex = 2;
            // 
            // adminViewDonations1
            // 
            adminViewDonations1.Location = new Point(-2, -2);
            adminViewDonations1.Name = "adminViewDonations1";
            adminViewDonations1.Size = new Size(1236, 818);
            adminViewDonations1.TabIndex = 5;
            // 
            // cashierCustomerForm1
            // 
            cashierCustomerForm1.Location = new Point(0, 0);
            cashierCustomerForm1.Name = "cashierCustomerForm1";
            cashierCustomerForm1.Size = new Size(1236, 818);
            cashierCustomerForm1.TabIndex = 4;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(0, 0);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1236, 818);
            adminAddProducts1.TabIndex = 3;
            // 
            // adminAddCatagories1
            // 
            adminAddCatagories1.Location = new Point(0, 0);
            adminAddCatagories1.Name = "adminAddCatagories1";
            adminAddCatagories1.Size = new Size(1236, 818);
            adminAddCatagories1.TabIndex = 2;
            // 
            // adminAddusers1
            // 
            adminAddusers1.Location = new Point(0, 0);
            adminAddusers1.Name = "adminAddusers1";
            adminAddusers1.Size = new Size(1236, 818);
            adminAddusers1.TabIndex = 1;
            // 
            // adminDashboard1
            // 
            adminDashboard1.Location = new Point(0, 0);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(1236, 818);
            adminDashboard1.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImageLayout = ImageLayout.None;
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(16, 455);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(71, 53);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button close;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Button admin_addProducts;
        private Button admin_addCatagories;
        private Button admin_addUser;
        private Button admin_logout;
        private Button admin_customer;
        private Panel panel3;
        private Button admin_Dashboard;
        private AdminAddCatagories adminAddCatagories5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CashierCustomerForm cashierCustomerForm1;
        private AdminAddProducts adminAddProducts1;
        private AdminAddCatagories adminAddCatagories1;
        private adminAddusers adminAddusers1;
        private adminDashboard adminDashboard1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button button1;
        private AdminViewDonations adminViewDonations1;
        private PictureBox pictureBox7;
    }
}