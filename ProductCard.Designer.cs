namespace Invetory_Management_System
{
    partial class ProductCard
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
            productImage = new PictureBox();
            productName = new Label();
            productPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)productImage).BeginInit();
            SuspendLayout();
            // 
            // productImage
            // 
            productImage.BackgroundImageLayout = ImageLayout.None;
            productImage.BorderStyle = BorderStyle.FixedSingle;
            productImage.Location = new Point(3, 3);
            productImage.Name = "productImage";
            productImage.Size = new Size(172, 131);
            productImage.SizeMode = PictureBoxSizeMode.StretchImage;
            productImage.TabIndex = 0;
            productImage.TabStop = false;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productName.Location = new Point(13, 150);
            productName.Name = "productName";
            productName.Size = new Size(60, 23);
            productName.TabIndex = 1;
            productName.Text = "label1";
            // 
            // productPrice
            // 
            productPrice.AutoSize = true;
            productPrice.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productPrice.Location = new Point(48, 184);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(60, 23);
            productPrice.TabIndex = 2;
            productPrice.Text = "label2";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(productPrice);
            Controls.Add(productName);
            Controls.Add(productImage);
            ForeColor = Color.FromArgb(0, 0, 192);
            Name = "ProductCard";
            Size = new Size(178, 248);
            ((System.ComponentModel.ISupportInitialize)productImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productImage;
        private Label productName;
        private Label productPrice;
    }
}
