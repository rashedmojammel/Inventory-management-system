using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invetory_Management_System
{
    public partial class PaymentForm : Form
    {
        public string SelectedPaymentMethod { get; private set; } = "";
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void addUser_updateBtn_Click(object sender, EventArgs e)
        {
            SelectedPaymentMethod = "bKash";
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void pay_nagad_Click(object sender, EventArgs e)
        {
            SelectedPaymentMethod = "Nagad";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {

        }
    }
}
