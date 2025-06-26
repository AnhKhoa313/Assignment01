using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository repo = OrderDetailRepository.Instance;

        public List<OrderDetail> GetOrderDetails() => repo.GetOrderDetails();
        public List<OrderDetail> GetOrderDetailsByOrderId(int orderId) => repo.GetOrderDetailsByOrderId(orderId);
        public void AddOrderDetail(OrderDetail detail) => repo.AddOrderDetail(detail);
        public void DeleteOrderDetailsByOrderId(int orderId) => repo.DeleteOrderDetailsByOrderId(orderId);
    }
}
