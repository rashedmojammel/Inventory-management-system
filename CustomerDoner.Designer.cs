namespace Invetory_Management_System
{
    partial class CustomerDoner
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
            Doner_clearBtn = new Button();
            label3 = new Label();
            DonerPhoneN = new TextBox();
            label2 = new Label();
            DonerName = new TextBox();
            label1 = new Label();
            DonerAmount = new TextBox();
            panel1 = new Panel();
            DonateBtn = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Doner_clearBtn
            // 
            Doner_clearBtn.BackColor = Color.FromArgb(85, 113, 73);
            Doner_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(117, 145, 105);
            Doner_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            Doner_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            Doner_clearBtn.FlatStyle = FlatStyle.Flat;
            Doner_clearBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Doner_clearBtn.ForeColor = Color.White;
            Doner_clearBtn.Location = new Point(154, 244);
            Doner_clearBtn.Name = "Doner_clearBtn";
            Doner_clearBtn.Size = new Size(115, 43);
            Doner_clearBtn.TabIndex = 23;
            Doner_clearBtn.Text = "Clear";
            Doner_clearBtn.UseVisualStyleBackColor = false;
            Doner_clearBtn.Click += Doner_clearBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 169);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 16;
            label3.Text = "Amount";
            // 
            // DonerPhoneN
            // 
            DonerPhoneN.BorderStyle = BorderStyle.FixedSingle;
            DonerPhoneN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DonerPhoneN.Location = new Point(17, 136);
            DonerPhoneN.Name = "DonerPhoneN";
            DonerPhoneN.Size = new Size(252, 30);
            DonerPhoneN.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 108);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 14;
            label2.Text = "Phone Number";
            // 
            // DonerName
            // 
            DonerName.BorderStyle = BorderStyle.FixedSingle;
            DonerName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DonerName.Location = new Point(17, 75);
            DonerName.Name = "DonerName";
            DonerName.Size = new Size(252, 30);
            DonerName.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 39);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // DonerAmount
            // 
            DonerAmount.BorderStyle = BorderStyle.FixedSingle;
            DonerAmount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DonerAmount.Location = new Point(17, 197);
            DonerAmount.Name = "DonerAmount";
            DonerAmount.Size = new Size(252, 30);
            DonerAmount.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(DonateBtn);
            panel1.Controls.Add(DonerPhoneN);
            panel1.Controls.Add(DonerAmount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Doner_clearBtn);
            panel1.Controls.Add(DonerName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(14, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 561);
            panel1.TabIndex = 25;
            // 
            // DonateBtn
            // 
            DonateBtn.BackColor = Color.FromArgb(85, 113, 73);
            DonateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(117, 145, 105);
            DonateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            DonateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            DonateBtn.FlatStyle = FlatStyle.Flat;
            DonateBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DonateBtn.ForeColor = Color.White;
            DonateBtn.Location = new Point(17, 244);
            DonateBtn.Name = "DonateBtn";
            DonateBtn.Size = new Size(115, 43);
            DonateBtn.TabIndex = 25;
            DonateBtn.Text = "Donate";
            DonateBtn.UseVisualStyleBackColor = false;
            DonateBtn.Click += DonateBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(301, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 561);
            panel2.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(192, 0, 0);
            textBox1.Location = new Point(14, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(940, 38);
            textBox1.TabIndex = 27;
            textBox1.Text = "Every donation—big or small—helps us bring hope and support to those who need it most.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.f5866c3296118d09127f903bcf66abcb;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(653, 558);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CustomerDoner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerDoner";
            Size = new Size(989, 654);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Doner_clearBtn;
        private Label label3;
        private TextBox DonerPhoneN;
        private Label label2;
        private TextBox DonerName;
        private Label label1;
        private TextBox DonerAmount;
        private Panel panel1;
        private Panel panel2;
        private Button DonateBtn;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}
