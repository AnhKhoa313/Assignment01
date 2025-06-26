using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private static readonly OrderDetailRepository instance = new();
        public static OrderDetailRepository Instance => instance;

        private OrderDetailRepository() { }

        public List<OrderDetail> GetOrderDetails() => OrderDetailDAO.GetOrderDetails();
        public List<OrderDetail> GetOrderDetailsByOrderId(int orderId) => OrderDetailDAO.GetOrderDetailsByOrderId(orderId);
        public void AddOrderDetail(OrderDetail detail) => OrderDetailDAO.AddOrderDetail(detail);
        public void DeleteOrderDetailsByOrderId(int orderId) => OrderDetailDAO.DeleteOrderDetailsByOrderId(orderId);
    }
}
