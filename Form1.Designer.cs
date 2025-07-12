namespace Invetory_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            login_showPassoword = new CheckBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            register_label = new Label();
            label2 = new Label();
            login_btn = new Button();
            login_password = new TextBox();
            login_username = new TextBox();
            label1 = new Label();
            close = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(login_showPassoword);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(register_label);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(97, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 425);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // login_showPassoword
            // 
            login_showPassoword.AutoSize = true;
            login_showPassoword.Location = new Point(329, 321);
            login_showPassoword.Name = "login_showPassoword";
            login_showPassoword.Size = new Size(132, 24);
            login_showPassoword.TabIndex = 9;
            login_showPassoword.Text = "show password";
            login_showPassoword.UseVisualStyleBackColor = true;
            login_showPassoword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_lock_26px;
            pictureBox3.Location = new Point(144, 217);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 30);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(144, 172);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 30);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.BackColor = Color.White;
            register_label.Cursor = Cursors.Hand;
            register_label.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_label.ForeColor = SystemColors.Highlight;
            register_label.Location = new Point(356, 357);
            register_label.Name = "register_label";
            register_label.Size = new Size(115, 20);
            register_label.TabIndex = 5;
            register_label.Text = "Register here ";
            register_label.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(144, 357);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 4;
            label2.Text = "Have no account yet?";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(85, 113, 73);
            login_btn.FlatAppearance.BorderColor = Color.White;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(208, 264);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(224, 40);
            login_btn.TabIndex = 3;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += button2_Click;
            // 
            // login_password
            // 
            login_password.BorderStyle = BorderStyle.FixedSingle;
            login_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(182, 217);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(289, 30);
            login_password.TabIndex = 2;
            // 
            // login_username
            // 
            login_username.BorderStyle = BorderStyle.FixedSingle;
            login_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(182, 172);
            login_username.Name = "login_username";
            login_username.Size = new Size(289, 30);
            login_username.TabIndex = 1;
            login_username.TextChanged += login_username_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 128);
            label1.Name = "label1";
            label1.Size = new Size(175, 27);
            label1.TabIndex = 0;
            label1.Text = "Login Account";
            label1.Click += label1_Click;
            // 
            // close
            // 
            close.BackColor = Color.Firebrick;
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(723, 12);
            close.Name = "close";
            close.Size = new Size(33, 29);
            close.TabIndex = 0;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 113, 73);
            ClientSize = new Size(768, 517);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button close;
        private Label label1;
        private TextBox login_username;
        private Button login_btn;
        private TextBox login_password;
        private Label register_label;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private CheckBox login_showPassoword;
    }
}
