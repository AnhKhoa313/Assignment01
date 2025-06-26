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
    /// Interaction logic for OrderDialog.xaml
    /// </summary>
    public partial class OrderDialog : Window
    {
        public Order Order { get; private set; } = new Order();
        public List<OrderDetail> OrderDetails { get; private set; } = new();

        private readonly Employee currentEmployee;
        private readonly List<Product> allProducts;
        private readonly List<Customer> allCustomers;

        public OrderDialog(Employee employee)
        {
            InitializeComponent();

            currentEmployee = employee;
            allProducts = new ProductService().GetProducts();
            allCustomers = new CustomerService().GetCustomers();

            cbProduct.ItemsSource = allProducts;
            cbCustomer.ItemsSource = allCustomers;

            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void BtnAddItem_Click(object sender, RoutedEventArgs e)
        {
            if (cbProduct.SelectedItem is not Product product ||
                !int.TryParse(txtQty.Text, out int qty) ||
                !float.TryParse(txtDiscount.Text, out float discount))
            {
                MessageBox.Show("Invalid input.");
                return;
            }

            if (qty <= 0 || discount < 0 || discount > 1)
            {
                MessageBox.Show("Quantity must be > 0 and discount must be between 0 and 1.");
                return;
            }

            var detail = new OrderDetail
            {
                ProductID = product.ProductID,
                UnitPrice = product.UnitPrice,
                Quantity = qty,
                Discount = discount
            };

            OrderDetails.Add(detail);
            dgItems.ItemsSource = null;
            dgItems.ItemsSource = OrderDetails;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cbCustomer.SelectedValue == null || OrderDetails.Count == 0)
            {
                MessageBox.Show("Please select a customer and add at least one item.");
                return;
            }

            var orders = new OrderService().GetOrders();
            int newOrderId = orders.Count == 0 ? 1 : orders[^1].OrderID + 1;

            Order.OrderID = newOrderId;
            Order.CustomerID = (int)cbCustomer.SelectedValue;
            Order.EmployeeID = currentEmployee.EmployeeID;
            Order.OrderDate = DateTime.Now;

            foreach (var item in OrderDetails)
                item.OrderID = newOrderId;

            this.DialogResult = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
