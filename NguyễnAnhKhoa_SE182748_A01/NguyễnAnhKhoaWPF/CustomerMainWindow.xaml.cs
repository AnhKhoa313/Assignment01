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
    /// Interaction logic for CustomerMainWindow.xaml
    /// </summary>
    public partial class CustomerMainWindow : Window
    {
        private readonly Customer currentCustomer;
        private readonly IOrderService orderService = new OrderService();
        private readonly ICustomerService customerService = new CustomerService();

        public CustomerMainWindow(Customer customer)
        {
            InitializeComponent();
            currentCustomer = customer;
            txtWelcome.Text = $"Welcome, {customer.ContactName}";
            LoadOrders();
        }

        private void LoadOrders()
        {
            var list = orderService.GetOrders().Where(o => o.CustomerID == currentCustomer.CustomerID).ToList();
            dgOrders.ItemsSource = null;
            dgOrders.ItemsSource = list;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CustomerDialog(currentCustomer);
            if (dialog.ShowDialog() == true)
            {
                customerService.UpdateCustomer(dialog.Customer);
                MessageBox.Show("Profile updated.");
                txtWelcome.Text = $"Welcome, {dialog.Customer.ContactName}";
            }
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            new LoginWindow().Show();
            this.Close();
        }
    }
}
