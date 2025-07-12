namespace Invetory_Management_System
{
    partial class CustomerEditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEditProfile));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            _currentUsername = new TextBox();
            label3 = new Label();
            addUser_updateBtn = new Button();
            addUser_Password = new TextBox();
            label2 = new Label();
            addUsers_username = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(_currentUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addUser_updateBtn);
            panel1.Controls.Add(addUser_Password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addUsers_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(19, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 623);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = Properties.Resources.icons8_lock_26px;
            pictureBox3.Location = new Point(280, 299);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.icons8_name_80px_1;
            pictureBox2.Location = new Point(283, 209);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(285, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // _currentUsername
            // 
            _currentUsername.BorderStyle = BorderStyle.FixedSingle;
            _currentUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _currentUsername.Location = new Point(360, 148);
            _currentUsername.Name = "_currentUsername";
            _currentUsername.Size = new Size(252, 30);
            _currentUsername.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(360, 120);
            label3.Name = "label3";
            label3.Size = new Size(169, 25);
            label3.TabIndex = 10;
            label3.Text = "Current username";
            label3.Click += label3_Click;
            // 
            // addUser_updateBtn
            // 
            addUser_updateBtn.BackColor = Color.FromArgb(85, 113, 73);
            addUser_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(117, 145, 105);
            addUser_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            addUser_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            addUser_updateBtn.FlatStyle = FlatStyle.Flat;
            addUser_updateBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_updateBtn.ForeColor = Color.White;
            addUser_updateBtn.Location = new Point(414, 413);
            addUser_updateBtn.Name = "addUser_updateBtn";
            addUser_updateBtn.Size = new Size(115, 43);
            addUser_updateBtn.TabIndex = 9;
            addUser_updateBtn.Text = "Update";
            addUser_updateBtn.UseVisualStyleBackColor = false;
            addUser_updateBtn.Click += addUser_updateBtn_Click;
            // 
            // addUser_Password
            // 
            addUser_Password.BorderStyle = BorderStyle.FixedSingle;
            addUser_Password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_Password.Location = new Point(360, 327);
            addUser_Password.Name = "addUser_Password";
            addUser_Password.Size = new Size(252, 30);
            addUser_Password.TabIndex = 3;
            addUser_Password.TextChanged += addUser_Password_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(364, 299);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // addUsers_username
            // 
            addUsers_username.BorderStyle = BorderStyle.FixedSingle;
            addUsers_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUsers_username.Location = new Point(360, 237);
            addUsers_username.Name = "addUsers_username";
            addUsers_username.Size = new Size(252, 30);
            addUsers_username.TabIndex = 1;
            addUsers_username.TextChanged += addUsers_username_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 200);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // CustomerEditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CustomerEditProfile";
            Size = new Size(989, 654);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button addUser_updateBtn;
        private TextBox addUser_Password;
        private Label label2;
        private TextBox addUsers_username;
        private Label label1;
        private TextBox _currentUsername;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        //private TextBox _currentUsername;
    }
}
