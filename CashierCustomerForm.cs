using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invetory_Management_System
{
    public partial class CashierCustomerForm : UserControl
    {
        public CashierCustomerForm()
        {
            InitializeComponent();
            displayCustomers();
        }

        public void displayCustomers()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.allCustomers();

            dataGridView1.DataSource = listData;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
