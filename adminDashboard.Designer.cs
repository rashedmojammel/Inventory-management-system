namespace Invetory_Management_System
{
    partial class adminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashboard));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel6 = new Panel();
            dataGridView4 = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            dashboard_AU = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            dashboard_TI = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel3 = new Panel();
            dashboard_AC = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            dashboard_totalIncome = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dataGridView4);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(12, 241);
            panel6.Name = "panel6";
            panel6.Size = new Size(965, 396);
            panel6.TabIndex = 6;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 113, 73);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(85, 113, 73);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView4.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView4.Location = new Point(14, 39);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(936, 354);
            dataGridView4.TabIndex = 17;
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
            label3.Click += label3_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(85, 113, 73);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dashboard_AU);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 147);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(85, 113, 73);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(dashboard_TI);
            panel5.Location = new Point(480, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 147);
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
            pictureBox3.Location = new Point(-3, 31);
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
            dashboard_TI.Location = new Point(95, 31);
            dashboard_TI.Name = "dashboard_TI";
            dashboard_TI.Size = new Size(49, 20);
            dashboard_TI.TabIndex = 7;
            dashboard_TI.Text = "$0.00";
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(85, 113, 73);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(dashboard_AC);
            panel3.Location = new Point(239, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 147);
            panel3.TabIndex = 1;
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
            pictureBox4.Size = new Size(86, 86);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // dashboard_totalIncome
            // 
            dashboard_totalIncome.AutoSize = true;
            dashboard_totalIncome.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_totalIncome.ForeColor = Color.White;
            dashboard_totalIncome.Location = new Point(95, 31);
            dashboard_totalIncome.Name = "dashboard_totalIncome";
            dashboard_totalIncome.Size = new Size(49, 20);
            dashboard_totalIncome.TabIndex = 10;
            dashboard_totalIncome.Text = "$0.00";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(85, 113, 73);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(dashboard_totalIncome);
            panel4.Location = new Point(726, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 147);
            panel4.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 186);
            panel1.TabIndex = 5;
            // 
            // adminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "adminDashboard";
            Size = new Size(989, 654);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel6;
        private Label label1;
        private Label label3;
        private Label dashboard_AU;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel5;
        private Label label6;
        private PictureBox pictureBox3;
        private Label dashboard_TI;
        private PictureBox pictureBox2;
        private Label label4;
        private Panel panel3;
        private Label dashboard_AC;
        private Label label8;
        private PictureBox pictureBox4;
        private Label dashboard_totalIncome;
        private Panel panel4;
        private Panel panel1;
        private DataGridView dataGridView4;
    }
}
