using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository repo = OrderRepository.Instance;

        public List<Order> GetOrders() => repo.GetOrders();
        public Order? GetOrderById(int id) => repo.GetOrderById(id);
        public void AddOrder(Order order) => repo.AddOrder(order);
        public void UpdateOrder(Order order) => repo.UpdateOrder(order);
        public void DeleteOrder(int id) => repo.DeleteOrder(id);
    }
}
