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
    public partial class ProductGallery : UserControl
    {
        public ProductGallery()
        {
            InitializeComponent();
            LoadProducts();
        }
        private void LoadProducts()
        {
            flowLayoutPanel1.Controls.Clear();

            AddProductsData apData = new AddProductsData();
            List<AddProductsData> allProducts = apData.AllProductsData();

            foreach (var product in allProducts)
            {
                if (product.Status == "Available")
                {
                    ProductCard card = new ProductCard();
                    card.SetData(product.ProdName, product.Price.ToString(), product.ImagePath, product.Stock);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }

        private void ProductGallery_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchbtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = searchbtn.Text.ToLower().Trim();
            flowLayoutPanel1.Controls.Clear();

            AddProductsData apData = new AddProductsData();
            List<AddProductsData> allProducts = apData.AllProductsData();

            foreach (var product in allProducts)
            {
                if (product.Status == "Available" && product.ProdName.ToLower().Contains(searchText))
                {
                    ProductCard card = new ProductCard();
                    card.SetData(product.ProdName, product.Price, product.ImagePath, product.Stock);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }
    }
}