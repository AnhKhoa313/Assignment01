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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private readonly ICustomerService customerService = new CustomerService();
        private List<Customer> customerList = new();

        public CustomerWindow(bool isAdmin)
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            customerList = customerService.GetCustomers();
            dgCustomers.ItemsSource = null;
            dgCustomers.ItemsSource = customerList;
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            var keyword = txtSearch.Text.Trim().ToLower();
            var filtered = customerList.Where(c =>
                c.CompanyName.ToLower().Contains(keyword) ||
                c.ContactName.ToLower().Contains(keyword) ||
                c.Phone.ToLower().Contains(keyword)).ToList();

            dgCustomers.ItemsSource = filtered;
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtSearch.Text = "";
            LoadCustomers();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CustomerDialog(null);
            if (dialog.ShowDialog() == true)
            {
                customerService.AddCustomer(dialog.Customer);
                LoadCustomers();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgCustomers.SelectedItem is Customer selected)
            {
                var dialog = new CustomerDialog(selected);
                if (dialog.ShowDialog() == true)
                {
                    customerService.UpdateCustomer(dialog.Customer);
                    LoadCustomers();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgCustomers.SelectedItem is Customer selected)
            {
                var result = MessageBox.Show($"Delete customer {selected.ContactName}?", "Confirm", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    customerService.DeleteCustomer(selected.CustomerID);
                    LoadCustomers();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
