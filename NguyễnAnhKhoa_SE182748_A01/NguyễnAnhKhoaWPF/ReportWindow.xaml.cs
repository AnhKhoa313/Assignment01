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
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        private readonly IOrderService orderService = new OrderService();

        public ReportWindow()
        {
            InitializeComponent();
            dpFrom.SelectedDate = DateTime.Now.AddDays(-7);
            dpTo.SelectedDate = DateTime.Now;
        }

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            if (dpFrom.SelectedDate == null || dpTo.SelectedDate == null)
            {
                MessageBox.Show("Please select a date range.");
                return;
            }

            DateTime from = dpFrom.SelectedDate.Value;
            DateTime to = dpTo.SelectedDate.Value.AddDays(1); // include the end date

            List<Order> filtered = orderService.GetOrders()
                .Where(o => o.OrderDate >= from && o.OrderDate < to)
                .OrderByDescending(o => o.OrderDate)
                .ToList();

            dgReport.ItemsSource = null;
            dgReport.ItemsSource = filtered;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
