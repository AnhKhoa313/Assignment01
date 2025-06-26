using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public class OrderDetailDAO
    {
        private static List<OrderDetail> orderDetails = new();
        private static readonly object lockObj = new();

        public static List<OrderDetail> GetOrderDetails() => orderDetails;

        public static List<OrderDetail> GetOrderDetailsByOrderId(int orderId) =>
            orderDetails.Where(od => od.OrderID == orderId).ToList();

        public static void AddOrderDetail(OrderDetail detail)
        {
            lock (lockObj)
            {
                orderDetails.Add(detail);
            }
        }

        public static void DeleteOrderDetailsByOrderId(int orderId)
        {
            var items = orderDetails.Where(od => od.OrderID == orderId).ToList();
            foreach (var item in items)
            {
                orderDetails.Remove(item);
            }
        }
    }
}
