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

namespace NguyễnAnhKhoaWPF
{
    /// <summary>
    /// Interaction logic for CustomerDialog.xaml
    /// </summary>
    public partial class CustomerDialog : Window
    {
        public Customer Customer { get; private set; }

        private bool isEdit;

        public CustomerDialog(Customer? existingCustomer)
        {
            InitializeComponent();

            isEdit = existingCustomer != null;

            if (isEdit)
            {
                // Editing
                Customer = new Customer
                {
                    CustomerID = existingCustomer.CustomerID,
                    CompanyName = existingCustomer.CompanyName,
                    ContactName = existingCustomer.ContactName,
                    ContactTitle = existingCustomer.ContactTitle,
                    Address = existingCustomer.Address,
                    Phone = existingCustomer.Phone
                };

                txtID.Text = Customer.CustomerID.ToString();
                txtCompany.Text = Customer.CompanyName;
                txtContact.Text = Customer.ContactName;
                txtTitle.Text = Customer.ContactTitle;
                txtAddress.Text = Customer.Address;
                txtPhone.Text = Customer.Phone;
            }
            else
            {
                // Creating new
                Customer = new Customer();
                txtID.Text = GenerateCustomerId().ToString();
            }
        }

        private int GenerateCustomerId()
        {
            var list = new Services.CustomerService().GetCustomers();
            return list.Count == 0 ? 1 : list[^1].CustomerID + 1;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompany.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in required fields.");
                return;
            }

            Customer.CustomerID = int.Parse(txtID.Text);
            Customer.CompanyName = txtCompany.Text.Trim();
            Customer.ContactName = txtContact.Text.Trim();
            Customer.ContactTitle = txtTitle.Text.Trim();
            Customer.Address = txtAddress.Text.Trim();
            Customer.Phone = txtPhone.Text.Trim();

            this.DialogResult = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
