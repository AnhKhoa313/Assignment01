using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessObjects;

namespace NguyễnAnhKhoaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Employee employee;

        public MainWindow(Employee emp)
        {
            InitializeComponent();
            employee = emp;
            txtWelcome.Text = $"Welcome, {employee.Name} ({employee.JobTitle})";
        }

        private void BtnCustomers_Click(object sender, RoutedEventArgs e)
        {
            var win = new CustomerWindow(true); // true = Admin mode
            win.ShowDialog();
        }

        private void BtnProducts_Click(object sender, RoutedEventArgs e)
        {
            var win = new ProductWindow();
            win.ShowDialog();
        }

        private void BtnOrders_Click(object sender, RoutedEventArgs e)
        {
            var win = new OrderWindow(employee); // pass current employee
            win.ShowDialog();
        }

        private void BtnReports_Click(object sender, RoutedEventArgs e)
        {
            var win = new ReportWindow();
            win.ShowDialog();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            new LoginWindow().Show();
            this.Close();
        }
    }
}