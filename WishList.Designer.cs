namespace Invetory_Management_System
{
    partial class WishList
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
            panel1 = new Panel();
            Rq_qty = new NumericUpDown();
            DonateBtn = new Button();
            ReqProdName = new TextBox();
            label1 = new Label();
            Doner_clearBtn = new Button();
            ReqName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Rq_qty).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Rq_qty);
            panel1.Controls.Add(DonateBtn);
            panel1.Controls.Add(ReqProdName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Doner_clearBtn);
            panel1.Controls.Add(ReqName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(16, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 623);
            panel1.TabIndex = 26;
            // 
            // Rq_qty
            // 
            Rq_qty.Location = new Point(17, 197);
            Rq_qty.Name = "Rq_qty";
            Rq_qty.Size = new Size(252, 27);
            Rq_qty.TabIndex = 28;
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
            DonateBtn.Text = "Submit";
            DonateBtn.UseVisualStyleBackColor = false;
            DonateBtn.Click += DonateBtn_Click;
            // 
            // ReqProdName
            // 
            ReqProdName.BorderStyle = BorderStyle.FixedSingle;
            ReqProdName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReqProdName.Location = new Point(17, 136);
            ReqProdName.Name = "ReqProdName";
            ReqProdName.Size = new Size(252, 30);
            ReqProdName.TabIndex = 15;
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
            // 
            // ReqName
            // 
            ReqName.BorderStyle = BorderStyle.FixedSingle;
            ReqName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReqName.Location = new Point(17, 75);
            ReqName.Name = "ReqName";
            ReqName.Size = new Size(252, 30);
            ReqName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 108);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 14;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 169);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 16;
            label3.Text = "Quantity";
            // 
            // WishList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "WishList";
            Size = new Size(989, 654);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Rq_qty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button DonateBtn;
        private TextBox ReqProdName;
        private Label label1;
        private Button Doner_clearBtn;
        private TextBox ReqName;
        private Label label2;
        private Label label3;
        private NumericUpDown Rq_qty;
    }
}
