namespace Invetory_Management_System
{
    partial class AdminViewDonations
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            DonorSearch = new TextBox();
            DonateBtn = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(DonorSearch);
            panel2.Controls.Add(DonateBtn);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(13, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 623);
            panel2.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cb6ad9e4ac8373f71c882e315de457d6;
            pictureBox1.Location = new Point(634, 392);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // DonorSearch
            // 
            DonorSearch.BorderStyle = BorderStyle.FixedSingle;
            DonorSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DonorSearch.Location = new Point(15, 414);
            DonorSearch.Name = "DonorSearch";
            DonorSearch.PlaceholderText = "   Search here......";
            DonorSearch.Size = new Size(339, 30);
            DonorSearch.TabIndex = 27;
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
            DonateBtn.Location = new Point(15, 460);
            DonateBtn.Name = "DonateBtn";
            DonateBtn.Size = new Size(339, 43);
            DonateBtn.TabIndex = 26;
            DonateBtn.Text = "Search";
            DonateBtn.UseVisualStyleBackColor = false;
            DonateBtn.Click += DonateBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 113, 73);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(85, 113, 73);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(15, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(919, 335);
            dataGridView1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 8);
            label5.Name = "label5";
            label5.Size = new Size(121, 29);
            label5.TabIndex = 12;
            label5.Text = "Donations";
            // 
            // AdminViewDonations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "AdminViewDonations";
            Size = new Size(989, 654);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label5;
        private Button DonateBtn;
        private TextBox DonorSearch;
        private PictureBox pictureBox1;
    }
}
