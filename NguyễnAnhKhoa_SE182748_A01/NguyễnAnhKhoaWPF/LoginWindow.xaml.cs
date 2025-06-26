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
using Services;

namespace NguyễnAnhKhoaWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly IEmployeeService employeeService = new EmployeeService();
        private readonly ICustomerService customerService = new CustomerService();

        public LoginWindow()
        {
            InitializeComponent();
            DataAccessLayer.DataSource.SeedData(); // Seed in-memory
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string role = (cbRole.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "";
            string user = txtUser.Text.Trim();
            string pass = txtPassword.Password;

            if (role == "Admin")
            {
                var emp = employeeService.GetByCredentials(user, pass);
                if (emp != null)
                {
                    var main = new MainWindow(emp); // Admin view
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid admin credentials.");
                }
            }
            else if (role == "Customer")
            {
                var cust = customerService.GetCustomers().FirstOrDefault(c => c.Phone == user);
                if (cust != null)
                {
                    var main = new CustomerMainWindow(cust); // Customer view
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Phone not found.");
                }
            }
        }
    }
}
