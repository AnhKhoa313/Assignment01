using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessObjects;
using Services;

namespace NguyễnAnhKhoaWPF
{
    /// <summary>
    /// Interaction logic for ProductDialog.xaml
    /// </summary>
    public partial class ProductDialog : Window
    {
        public Product Product { get; private set; }

        private bool isEdit;

        public ProductDialog(Product? existing)
        {
            InitializeComponent();

            isEdit = existing != null;

            if (isEdit)
            {
                Product = new Product
                {
                    ProductID = existing.ProductID,
                    ProductName = existing.ProductName,
                    CategoryID = existing.CategoryID,
                    UnitPrice = existing.UnitPrice,
                    UnitsInStock = existing.UnitsInStock
                };

                txtID.Text = Product.ProductID.ToString();
                txtName.Text = Product.ProductName;
                txtCategory.Text = Product.CategoryID.ToString();
                txtPrice.Text = Product.UnitPrice.ToString(CultureInfo.InvariantCulture);
                txtStock.Text = Product.UnitsInStock.ToString();
            }
            else
            {
                Product = new Product();
                txtID.Text = GenerateProductId().ToString();
            }
        }

        private int GenerateProductId()
        {
            var list = new ProductService().GetProducts();
            return list.Count == 0 ? 1 : list[^1].ProductID + 1;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!int.TryParse(txtCategory.Text, out int categoryID) ||
                !decimal.TryParse(txtPrice.Text, out decimal price) ||
                !int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Invalid number format.");
                return;
            }

            Product.ProductID = int.Parse(txtID.Text);
            Product.ProductName = txtName.Text.Trim();
            Product.CategoryID = categoryID;
            Product.UnitPrice = price;
            Product.UnitsInStock = stock;

            this.DialogResult = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
