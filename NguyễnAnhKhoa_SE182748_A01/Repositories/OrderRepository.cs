using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private static readonly OrderRepository instance = new();
        public static OrderRepository Instance => instance;

        private OrderRepository() { }

        public List<Order> GetOrders() => OrderDAO.GetOrders();
        public Order? GetOrderById(int id) => OrderDAO.GetOrderById(id);
        public void AddOrder(Order order) => OrderDAO.AddOrder(order);
        public void UpdateOrder(Order order) => OrderDAO.UpdateOrder(order);
        public void DeleteOrder(int id) => OrderDAO.DeleteOrder(id);
    }
}
