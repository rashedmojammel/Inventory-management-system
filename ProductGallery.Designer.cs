namespace Invetory_Management_System
{
    partial class ProductGallery
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            searchbtn = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(13, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(962, 566);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // searchbtn
            // 
            searchbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbtn.Location = new Point(76, 30);
            searchbtn.Name = "searchbtn";
            searchbtn.PlaceholderText = "Search item....";
            searchbtn.Size = new Size(737, 34);
            searchbtn.TabIndex = 1;
            searchbtn.Click += searchbtn_Click;
            searchbtn.TextChanged += searchbtn_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_search_64px;
            pictureBox1.Location = new Point(13, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(85, 113, 73);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(819, 29);
            button1.Name = "button1";
            button1.Size = new Size(156, 35);
            button1.TabIndex = 22;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductGallery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(searchbtn);
            Controls.Add(flowLayoutPanel1);
            Name = "ProductGallery";
            Size = new Size(989, 654);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox searchbtn;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
