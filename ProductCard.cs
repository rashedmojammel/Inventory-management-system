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
    public partial class ProductCard: UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }
        public void SetData(string name, string price, string imagePath ,string Stock )
        {
            productName.Text = name;
            productPrice.Text = "৳ " + price;
           // stock.Text = "Stock: " + (string.IsNullOrEmpty(Stock) ? "N/A" : stock);

            if (File.Exists(imagePath))
            {
                using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    productImage.Image = Image.FromStream(fs);
                }
            }
            else
            {
                productImage.Image = null;
            }
        }
    }
}
