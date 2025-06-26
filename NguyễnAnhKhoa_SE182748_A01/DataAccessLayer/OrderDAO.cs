using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using System.Xml.Linq;

namespace DataAccessLayer
{
    public class OrderDAO
    {
        private static List<Order> orders = new();
        private static readonly object lockObj = new();

        public static List<Order> GetOrders() => orders;

        public static Order? GetOrderById(int id) =>
            orders.FirstOrDefault(o => o.OrderID == id);

        public static void AddOrder(Order order)
        {
            lock (lockObj)
            {
                orders.Add(order);
            }
        }

        public static void UpdateOrder(Order order)
        {
            var existing = GetOrderById(order.OrderID);
            if (existing != null)
            {
                existing.CustomerID = order.CustomerID;
                existing.EmployeeID = order.EmployeeID;
                existing.OrderDate = order.OrderDate;
            }
        }

        public static void DeleteOrder(int id)
        {
            var order = GetOrderById(id);
            if (order != null)
            {
                orders.Remove(order);
            }
        }
    }
}
