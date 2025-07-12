namespace Invetory_Management_System
{
    partial class AdminAdduUser
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            addUser_clearBtn = new Button();
            addUser_removeBtn = new Button();
            addUser_updateBtn = new Button();
            addUser_addBtn = new Button();
            addUser_status = new ComboBox();
            label4 = new Label();
            addUser_role = new ComboBox();
            label3 = new Label();
            addUser_Password = new TextBox();
            label2 = new Label();
            addUsers_username = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(addUser_clearBtn);
            panel1.Controls.Add(addUser_removeBtn);
            panel1.Controls.Add(addUser_updateBtn);
            panel1.Controls.Add(addUser_addBtn);
            panel1.Controls.Add(addUser_status);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addUser_role);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addUser_Password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addUsers_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(19, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 623);
            panel1.TabIndex = 2;
            // 
            // addUser_clearBtn
            // 
            addUser_clearBtn.BackColor = Color.FromArgb(85, 113, 73);
            addUser_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(117, 145, 105);
            addUser_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            addUser_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            addUser_clearBtn.FlatStyle = FlatStyle.Flat;
            addUser_clearBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_clearBtn.ForeColor = Color.White;
            addUser_clearBtn.Location = new Point(149, 411);
            addUser_clearBtn.Name = "addUser_clearBtn";
            addUser_clearBtn.Size = new Size(115, 43);
            addUser_clearBtn.TabIndex = 11;
            addUser_clearBtn.Text = "Clear";
            addUser_clearBtn.UseVisualStyleBackColor = false;
            // 
            // addUser_removeBtn
            // 
            addUser_removeBtn.BackColor = Color.FromArgb(85, 113, 73);
            addUser_removeBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(117, 145, 105);
            addUser_removeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            addUser_removeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            addUser_removeBtn.FlatStyle = FlatStyle.Flat;
            addUser_removeBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_removeBtn.ForeColor = Color.White;
            addUser_removeBtn.Location = new Point(16, 411);
            addUser_removeBtn.Name = "addUser_removeBtn";
            addUser_removeBtn.Size = new Size(115, 43);
            addUser_removeBtn.TabIndex = 10;
            addUser_removeBtn.Text = "Remove";
            addUser_removeBtn.UseVisualStyleBackColor = false;
            // 
            // addUser_updateBtn
            // 
            addUser_updateBtn.BackColor = Color.FromArgb(85, 113, 73);
            addUser_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(117, 145, 105);
            addUser_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            addUser_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            addUser_updateBtn.FlatStyle = FlatStyle.Flat;
            addUser_updateBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_updateBtn.ForeColor = Color.White;
            addUser_updateBtn.Location = new Point(149, 342);
            addUser_updateBtn.Name = "addUser_updateBtn";
            addUser_updateBtn.Size = new Size(115, 43);
            addUser_updateBtn.TabIndex = 9;
            addUser_updateBtn.Text = "Update";
            addUser_updateBtn.UseVisualStyleBackColor = false;
            // 
            // addUser_addBtn
            // 
            addUser_addBtn.BackColor = Color.FromArgb(85, 113, 73);
            addUser_addBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(117, 145, 105);
            addUser_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(117, 145, 105);
            addUser_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 145, 105);
            addUser_addBtn.FlatStyle = FlatStyle.Flat;
            addUser_addBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_addBtn.ForeColor = Color.White;
            addUser_addBtn.Location = new Point(16, 342);
            addUser_addBtn.Name = "addUser_addBtn";
            addUser_addBtn.Size = new Size(115, 43);
            addUser_addBtn.TabIndex = 8;
            addUser_addBtn.Text = "Add";
            addUser_addBtn.UseVisualStyleBackColor = false;
            addUser_addBtn.Click += addUser_addBtn_Click;
            // 
            // addUser_status
            // 
            addUser_status.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_status.FormattingEnabled = true;
            addUser_status.Items.AddRange(new object[] { "Active ", "Inactive", "Approval" });
            addUser_status.Location = new Point(12, 278);
            addUser_status.Name = "addUser_status";
            addUser_status.Size = new Size(252, 33);
            addUser_status.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 250);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 6;
            label4.Text = "Status";
            // 
            // addUser_role
            // 
            addUser_role.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_role.FormattingEnabled = true;
            addUser_role.Items.AddRange(new object[] { "Admin", "Cashier" });
            addUser_role.Location = new Point(12, 214);
            addUser_role.Name = "addUser_role";
            addUser_role.Size = new Size(252, 33);
            addUser_role.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 186);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // addUser_Password
            // 
            addUser_Password.BorderStyle = BorderStyle.FixedSingle;
            addUser_Password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_Password.Location = new Point(12, 153);
            addUser_Password.Name = "addUser_Password";
            addUser_Password.Size = new Size(252, 30);
            addUser_Password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // addUsers_username
            // 
            addUsers_username.BorderStyle = BorderStyle.FixedSingle;
            addUsers_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUsers_username.Location = new Point(12, 92);
            addUsers_username.Name = "addUsers_username";
            addUsers_username.Size = new Size(252, 30);
            addUsers_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(317, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 623);
            panel2.TabIndex = 3;
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
            dataGridView1.Location = new Point(15, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(625, 569);
            dataGridView1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 11);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 12;
            label5.Text = "All User's Data";
            // 
            // AdminAdduUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 654);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminAdduUser";
            Text = "AdminAdduUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button addUser_clearBtn;
        private Button addUser_removeBtn;
        private Button addUser_updateBtn;
        private Button addUser_addBtn;
        private ComboBox addUser_status;
        private Label label4;
        private ComboBox addUser_role;
        private Label label3;
        private TextBox addUser_Password;
        private Label label2;
        private TextBox addUsers_username;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label5;
    }
}