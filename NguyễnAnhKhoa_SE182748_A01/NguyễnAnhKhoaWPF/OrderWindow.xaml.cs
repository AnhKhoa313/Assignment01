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
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        private readonly IOrderService orderService = new OrderService();
        private readonly IOrderDetailService orderDetailService = new OrderDetailService();
        private readonly Employee currentEmployee;

        public OrderWindow(Employee emp)
        {
            InitializeComponent();
            currentEmployee = emp;
            LoadOrders();
        }

        private void LoadOrders()
        {
            dgOrders.ItemsSource = null;
            dgOrders.ItemsSource = orderService.GetOrders();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OrderDialog(currentEmployee);
            if (dialog.ShowDialog() == true)
            {
                orderService.AddOrder(dialog.Order);
                foreach (var item in dialog.OrderDetails)
                {
                    orderDetailService.AddOrderDetail(item);
                }
                LoadOrders();
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
