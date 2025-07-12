namespace Invetory_Management_System
{
    partial class CustomerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMainForm));
            panel1 = new Panel();
            close = new Button();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            Customer_Donate = new Button();
            pictureBox3 = new PictureBox();
            Customer_EditProfile = new Button();
            pictureBox6 = new PictureBox();
            Customer_placeorder = new Button();
            pictureBox5 = new PictureBox();
            Customer_AvailablePro = new Button();
            adminAddCatagories5 = new AdminAddCatagories();
            admin_logout = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            productGallery1 = new ProductGallery();
            customerPlaceOrders1 = new CustomerPlaceOrders();
            customerEditProfile1 = new CustomerEditProfile();
            customerDoner1 = new CustomerDoner();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(close);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 46);
            panel1.TabIndex = 1;
            // 
            // close
            // 
            close.BackColor = Color.Firebrick;
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(1155, 11);
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
            label1.Size = new Size(454, 21);
            label1.TabIndex = 1;
            label1.Text = "Inventory management system | Customer's portal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(85, 113, 73);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(Customer_Donate);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(Customer_EditProfile);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(Customer_placeorder);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(Customer_AvailablePro);
            panel2.Controls.Add(adminAddCatagories5);
            panel2.Controls.Add(admin_logout);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 654);
            panel2.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(4, 427);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(84, 59);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            // 
            // Customer_Donate
            // 
            Customer_Donate.FlatAppearance.BorderSize = 0;
            Customer_Donate.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            Customer_Donate.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            Customer_Donate.FlatStyle = FlatStyle.Flat;
            Customer_Donate.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer_Donate.ForeColor = Color.White;
            Customer_Donate.Location = new Point(87, 440);
            Customer_Donate.Name = "Customer_Donate";
            Customer_Donate.Size = new Size(110, 36);
            Customer_Donate.TabIndex = 39;
            Customer_Donate.Text = "Donate";
            Customer_Donate.UseVisualStyleBackColor = true;
            Customer_Donate.Click += Customer_Donate_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 340);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 78);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // Customer_EditProfile
            // 
            Customer_EditProfile.FlatAppearance.BorderSize = 0;
            Customer_EditProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            Customer_EditProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            Customer_EditProfile.FlatStyle = FlatStyle.Flat;
            Customer_EditProfile.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer_EditProfile.ForeColor = Color.White;
            Customer_EditProfile.Location = new Point(87, 365);
            Customer_EditProfile.Name = "Customer_EditProfile";
            Customer_EditProfile.Size = new Size(110, 36);
            Customer_EditProfile.TabIndex = 37;
            Customer_EditProfile.Text = "Edit Profile";
            Customer_EditProfile.UseVisualStyleBackColor = true;
            Customer_EditProfile.Click += Customer_EditProfile_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.None;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 286);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(71, 53);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 36;
            pictureBox6.TabStop = false;
            // 
            // Customer_placeorder
            // 
            Customer_placeorder.FlatAppearance.BorderSize = 0;
            Customer_placeorder.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            Customer_placeorder.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            Customer_placeorder.FlatStyle = FlatStyle.Flat;
            Customer_placeorder.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer_placeorder.ForeColor = Color.White;
            Customer_placeorder.Location = new Point(78, 287);
            Customer_placeorder.Name = "Customer_placeorder";
            Customer_placeorder.Size = new Size(112, 52);
            Customer_placeorder.TabIndex = 35;
            Customer_placeorder.Text = "Place orders";
            Customer_placeorder.UseVisualStyleBackColor = true;
            Customer_placeorder.Click += Customer_placeorder_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(8, 199);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(71, 63);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // Customer_AvailablePro
            // 
            Customer_AvailablePro.FlatAppearance.BorderSize = 0;
            Customer_AvailablePro.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            Customer_AvailablePro.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            Customer_AvailablePro.FlatStyle = FlatStyle.Flat;
            Customer_AvailablePro.Font = new Font("Microsoft New Tai Lue", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer_AvailablePro.ForeColor = Color.White;
            Customer_AvailablePro.Location = new Point(78, 210);
            Customer_AvailablePro.Name = "Customer_AvailablePro";
            Customer_AvailablePro.Size = new Size(112, 52);
            Customer_AvailablePro.TabIndex = 33;
            Customer_AvailablePro.Text = "Available Products";
            Customer_AvailablePro.UseVisualStyleBackColor = true;
            Customer_AvailablePro.Click += Customer_AvailablePro_Click;
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
            admin_logout.ForeColor = Color.White;
            admin_logout.Location = new Point(30, 595);
            admin_logout.Name = "admin_logout";
            admin_logout.Size = new Size(148, 36);
            admin_logout.TabIndex = 18;
            admin_logout.Text = "Log out";
            admin_logout.UseVisualStyleBackColor = false;
            admin_logout.Click += admin_logout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 8;
            label2.Text = "Welcome, Customer";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.icons8_user_80px;
            pictureBox1.Location = new Point(54, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // productGallery1
            // 
            productGallery1.Location = new Point(205, 46);
            productGallery1.Name = "productGallery1";
            productGallery1.Size = new Size(1236, 818);
            productGallery1.TabIndex = 3;
            // 
            // customerPlaceOrders1
            // 
            customerPlaceOrders1.Location = new Point(205, 46);
            customerPlaceOrders1.Name = "customerPlaceOrders1";
            customerPlaceOrders1.Size = new Size(1236, 818);
            customerPlaceOrders1.TabIndex = 4;
            // 
            // customerEditProfile1
            // 
            customerEditProfile1.Location = new Point(205, 46);
            customerEditProfile1.Name = "customerEditProfile1";
            customerEditProfile1.Size = new Size(1236, 818);
            customerEditProfile1.TabIndex = 5;
            // 
            // customerDoner1
            // 
            customerDoner1.Location = new Point(205, 46);
            customerDoner1.Name = "customerDoner1";
            customerDoner1.Size = new Size(1236, 818);
            customerDoner1.TabIndex = 6;
            // 
            // CustomerMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(customerDoner1);
            Controls.Add(customerEditProfile1);
            Controls.Add(customerPlaceOrders1);
            Controls.Add(productGallery1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button close;
        private Label label1;
        private Panel panel2;
        private AdminAddCatagories adminAddCatagories5;
        private Button admin_logout;
        private Label label2;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox5;
        private Button Customer_AvailablePro;
        private PictureBox pictureBox4;
        private Button Customer_Donate;
        private PictureBox pictureBox3;
        private Button Customer_EditProfile;
        private PictureBox pictureBox6;
        private Button Customer_placeorder;
        private ProductGallery productGallery1;
        private CustomerPlaceOrders customerPlaceOrders1;
        private CustomerEditProfile customerEditProfile1;
        private CustomerDoner customerDoner1;
    }
}