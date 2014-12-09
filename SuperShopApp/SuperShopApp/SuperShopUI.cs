using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopApp
{
    public partial class SuperShopUI : Form
    {
        public SuperShopUI()
        {
            InitializeComponent();
        }

        private Shop aShop;

        private void saveShopButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(nameShopTextBox.Text, addressShopTextBox.Text);
            MessageBox.Show("Shop Created!");
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product(productTextBox.Text, Convert.ToInt32(quantityTextBox.Text));
            string msg = aShop.AddProduct(aProduct);
            MessageBox.Show(msg);
        }

        private void showDetailButton_Click(object sender, EventArgs e)
        {
            string msg = "Product\tQuantity\n";
            foreach (Product allProducts in aShop.GetAllProducts())
            {
                msg += allProducts.ProductName + "\t" + allProducts.Quantity + "\n";
            }

            MessageBox.Show(msg);
        }
    }
}
