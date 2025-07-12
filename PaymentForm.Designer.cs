namespace Invetory_Management_System
{
    partial class PaymentForm
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
            panel1 = new Panel();
            label1 = new Label();
            close = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            addUser_updateBtn = new Button();
            pay_nagad = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 46);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(98, 26);
            label1.TabIndex = 3;
            label1.Text = "Payment ";
            // 
            // close
            // 
            close.BackColor = Color.Firebrick;
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(292, 9);
            close.Name = "close";
            close.Size = new Size(33, 29);
            close.TabIndex = 2;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.BKash_Logo_icon_700x662__1_;
            pictureBox1.Location = new Point(12, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.Nagad_Logo_wine;
            pictureBox2.Location = new Point(177, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // addUser_updateBtn
            // 
            addUser_updateBtn.BackColor = Color.FromArgb(85, 113, 73);
            addUser_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(117, 145, 105);
            addUser_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            addUser_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            addUser_updateBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_updateBtn.ForeColor = Color.White;
            addUser_updateBtn.Location = new Point(29, 221);
            addUser_updateBtn.Name = "addUser_updateBtn";
            addUser_updateBtn.Size = new Size(115, 43);
            addUser_updateBtn.TabIndex = 10;
            addUser_updateBtn.Text = "Pay";
            addUser_updateBtn.UseVisualStyleBackColor = false;
            addUser_updateBtn.Click += addUser_updateBtn_Click;
            // 
            // pay_nagad
            // 
            pay_nagad.BackColor = Color.FromArgb(85, 113, 73);
            pay_nagad.FlatAppearance.CheckedBackColor = Color.FromArgb(117, 145, 105);
            pay_nagad.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            pay_nagad.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            pay_nagad.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pay_nagad.ForeColor = Color.White;
            pay_nagad.Location = new Point(195, 221);
            pay_nagad.Name = "pay_nagad";
            pay_nagad.Size = new Size(115, 43);
            pay_nagad.TabIndex = 11;
            pay_nagad.Text = "Pay";
            pay_nagad.UseVisualStyleBackColor = false;
            pay_nagad.Click += pay_nagad_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 293);
            Controls.Add(pay_nagad);
            Controls.Add(addUser_updateBtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button close;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button addUser_updateBtn;
        private Button pay_nagad;
    }
}