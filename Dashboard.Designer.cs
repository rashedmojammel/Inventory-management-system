namespace Invetory_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            dashboard_totalincome = new Label();
            panel3 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            dashboard_AC = new Label();
            panel5 = new Panel();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            dashboard_TI = new Label();
            panel2 = new Panel();
            label3 = new Label();
            dashboard_AU = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 186);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(85, 113, 73);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(dashboard_totalincome);
            panel4.Location = new Point(737, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(216, 147);
            panel4.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(95, 97);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 11;
            label8.Text = "Total Income";
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(92, 86);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // dashboard_totalincome
            // 
            dashboard_totalincome.AutoSize = true;
            dashboard_totalincome.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_totalincome.ForeColor = Color.White;
            dashboard_totalincome.Location = new Point(101, 31);
            dashboard_totalincome.Name = "dashboard_totalincome";
            dashboard_totalincome.Size = new Size(49, 20);
            dashboard_totalincome.TabIndex = 10;
            dashboard_totalincome.Text = "$0.00";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(85, 113, 73);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(dashboard_AC);
            panel3.Location = new Point(254, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 147);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(102, 97);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 5;
            label4.Text = "All Customers";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // dashboard_AC
            // 
            dashboard_AC.AutoSize = true;
            dashboard_AC.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_AC.ForeColor = Color.White;
            dashboard_AC.Location = new Point(102, 31);
            dashboard_AC.Name = "dashboard_AC";
            dashboard_AC.Size = new Size(18, 20);
            dashboard_AC.TabIndex = 4;
            dashboard_AC.Text = "0";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(85, 113, 73);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(dashboard_TI);
            panel5.Location = new Point(496, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(221, 147);
            panel5.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(95, 97);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 8;
            label6.Text = "Today's Income";
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(92, 86);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // dashboard_TI
            // 
            dashboard_TI.AutoSize = true;
            dashboard_TI.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_TI.ForeColor = Color.White;
            dashboard_TI.Location = new Point(101, 31);
            dashboard_TI.Name = "dashboard_TI";
            dashboard_TI.Size = new Size(49, 20);
            dashboard_TI.TabIndex = 7;
            dashboard_TI.Text = "$0.00";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(85, 113, 73);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dashboard_AU);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(14, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 147);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(101, 97);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "All users";
            // 
            // dashboard_AU
            // 
            dashboard_AU.AutoSize = true;
            dashboard_AU.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_AU.ForeColor = Color.White;
            dashboard_AU.Location = new Point(101, 31);
            dashboard_AU.Name = "dashboard_AU";
            dashboard_AU.Size = new Size(18, 20);
            dashboard_AU.TabIndex = 1;
            dashboard_AU.Text = "0";
            dashboard_AU.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.icons8_user_groups_80px;
            pictureBox1.Location = new Point(3, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dataGridView1);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(12, 246);
            panel6.Name = "panel6";
            panel6.Size = new Size(965, 396);
            panel6.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(85, 113, 73);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(85, 113, 73);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(14, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(939, 342);
            dataGridView1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(197, 23);
            label1.TabIndex = 1;
            label1.Text = "All Today's Customer";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 654);
            Controls.Add(panel6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label dashboard_AU;
        private Label label4;
        private PictureBox pictureBox2;
        private Label dashboard_AC;
        private Label label6;
        private PictureBox pictureBox3;
        private Label dashboard_TI;
        private Label label8;
        private PictureBox pictureBox4;
        private Label dashboard_totalincome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
    }
}