using System;
using System.Collections.Generic;
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
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private readonly IProductService productService = new ProductService();
        private List<Product> productList = new();

        public ProductWindow()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            productList = productService.GetProducts();
            dgProducts.ItemsSource = null;
            dgProducts.ItemsSource = productList;
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var filtered = productList.Where(p =>
                p.ProductName.ToLower().Contains(keyword)).ToList();
            dgProducts.ItemsSource = filtered;
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtSearch.Text = "";
            LoadProducts();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ProductDialog(null);
            if (dialog.ShowDialog() == true)
            {
                productService.AddProduct(dialog.Product);
                LoadProducts();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgProducts.SelectedItem is Product selected)
            {
                var dialog = new ProductDialog(selected);
                if (dialog.ShowDialog() == true)
                {
                    productService.UpdateProduct(dialog.Product);
                    LoadProducts();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgProducts.SelectedItem is Product selected)
            {
                var confirm = MessageBox.Show($"Delete product {selected.ProductName}?", "Confirm", MessageBoxButton.YesNo);
                if (confirm == MessageBoxResult.Yes)
                {
                    productService.DeleteProduct(selected.ProductID);
                    LoadProducts();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
