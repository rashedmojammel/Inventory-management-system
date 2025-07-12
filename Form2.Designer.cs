namespace Invetory_Management_System
{
    partial class RegisterForm
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
            close = new Button();
            panel1 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            register_gender = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            register_email = new TextBox();
            label7 = new Label();
            label8 = new Label();
            register_phone = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            register_showPassword = new CheckBox();
            register_cPassword = new TextBox();
            register_label = new Label();
            label2 = new Label();
            login_btn = new Button();
            register_password = new TextBox();
            register_username = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // close
            // 
            close.BackColor = Color.Firebrick;
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(843, 12);
            close.Name = "close";
            close.Size = new Size(33, 29);
            close.TabIndex = 1;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(register_gender);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(register_email);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(register_phone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(register_showPassword);
            panel1.Controls.Add(register_cPassword);
            panel1.Controls.Add(register_label);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(register_password);
            panel1.Controls.Add(register_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(107, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 514);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(159, 343);
            label11.Name = "label11";
            label11.Size = new Size(156, 23);
            label11.TabIndex = 28;
            label11.Text = "Confirm Password";
            label11.UseWaitCursor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(144, 346);
            label12.Name = "label12";
            label12.Size = new Size(18, 23);
            label12.TabIndex = 27;
            label12.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(156, 283);
            label13.Name = "label13";
            label13.Size = new Size(85, 23);
            label13.TabIndex = 26;
            label13.Text = "Password";
            label13.UseWaitCursor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(141, 283);
            label14.Name = "label14";
            label14.Size = new Size(18, 23);
            label14.TabIndex = 25;
            label14.Text = "*";
            // 
            // register_gender
            // 
            register_gender.BackColor = Color.DarkGray;
            register_gender.FormattingEnabled = true;
            register_gender.Items.AddRange(new object[] { "Male", "Female" });
            register_gender.Location = new Point(144, 252);
            register_gender.Name = "register_gender";
            register_gender.Size = new Size(392, 28);
            register_gender.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(159, 223);
            label9.Name = "label9";
            label9.Size = new Size(68, 23);
            label9.TabIndex = 21;
            label9.Text = "Gender";
            label9.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(144, 226);
            label10.Name = "label10";
            label10.Size = new Size(18, 23);
            label10.TabIndex = 20;
            label10.Text = "*";
            // 
            // register_email
            // 
            register_email.BackColor = Color.DarkGray;
            register_email.BorderStyle = BorderStyle.FixedSingle;
            register_email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_email.Location = new Point(141, 190);
            register_email.Name = "register_email";
            register_email.Size = new Size(395, 30);
            register_email.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(159, 161);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 18;
            label7.Text = "Email";
            label7.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(144, 164);
            label8.Name = "label8";
            label8.Size = new Size(18, 23);
            label8.TabIndex = 17;
            label8.Text = "*";
            // 
            // register_phone
            // 
            register_phone.BackColor = Color.DarkGray;
            register_phone.BorderStyle = BorderStyle.FixedSingle;
            register_phone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_phone.Location = new Point(141, 128);
            register_phone.Name = "register_phone";
            register_phone.Size = new Size(395, 30);
            register_phone.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(156, 102);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
            label5.TabIndex = 15;
            label5.Text = "Phone number";
            label5.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(141, 105);
            label6.Name = "label6";
            label6.Size = new Size(18, 23);
            label6.TabIndex = 14;
            label6.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(156, 40);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 13;
            label4.Text = "Name";
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(141, 43);
            label3.Name = "label3";
            label3.Size = new Size(18, 23);
            label3.TabIndex = 12;
            label3.Text = "*";
            // 
            // register_showPassword
            // 
            register_showPassword.AutoSize = true;
            register_showPassword.Location = new Point(434, 402);
            register_showPassword.Name = "register_showPassword";
            register_showPassword.Size = new Size(134, 24);
            register_showPassword.TabIndex = 11;
            register_showPassword.Text = "Show password";
            register_showPassword.UseVisualStyleBackColor = true;
            register_showPassword.CheckedChanged += register_showPassword_CheckedChanged;
            // 
            // register_cPassword
            // 
            register_cPassword.BackColor = Color.DarkGray;
            register_cPassword.BorderStyle = BorderStyle.FixedSingle;
            register_cPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_cPassword.Location = new Point(144, 369);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.PasswordChar = '*';
            register_cPassword.Size = new Size(392, 30);
            register_cPassword.TabIndex = 9;
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.BackColor = Color.White;
            register_label.Cursor = Cursors.Hand;
            register_label.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_label.ForeColor = SystemColors.Highlight;
            register_label.Location = new Point(420, 485);
            register_label.Name = "register_label";
            register_label.Size = new Size(103, 20);
            register_label.TabIndex = 5;
            register_label.Text = "Sign in here ";
            register_label.Click += register_label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(144, 485);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 4;
            label2.Text = "Already have an account?";
            label2.Click += label2_Click;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(85, 113, 73);
            login_btn.FlatAppearance.BorderColor = Color.White;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(218, 432);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(248, 40);
            login_btn.TabIndex = 3;
            login_btn.Text = "Signup";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // register_password
            // 
            register_password.BackColor = Color.DarkGray;
            register_password.BorderStyle = BorderStyle.FixedSingle;
            register_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_password.Location = new Point(144, 309);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(392, 30);
            register_password.TabIndex = 2;
            // 
            // register_username
            // 
            register_username.BackColor = Color.DarkGray;
            register_username.BorderStyle = BorderStyle.FixedSingle;
            register_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_username.Location = new Point(141, 69);
            register_username.Name = "register_username";
            register_username.Size = new Size(395, 30);
            register_username.TabIndex = 1;
            register_username.TextChanged += login_username_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 10);
            label1.Name = "label1";
            label1.Size = new Size(173, 34);
            label1.TabIndex = 0;
            label1.Text = "Register Account";
            label1.Click += label1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 113, 73);
            ClientSize = new Size(909, 600);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button close;
        private Panel panel1;
        private Label register_label;
        private Label label2;
        private Button login_btn;
        private TextBox register_password;
        private TextBox register_username;
        private Label label1;
        private TextBox register_cPassword;
        private CheckBox register_showPassword;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label10;
        private TextBox register_email;
        private Label label7;
        private Label label8;
        private TextBox register_phone;
        private Label label5;
        private Label label6;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox register_gender;
    }
}