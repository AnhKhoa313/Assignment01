using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Services
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetOrderDetails();
        List<OrderDetail> GetOrderDetailsByOrderId(int orderId);
        void AddOrderDetail(OrderDetail detail);
        void DeleteOrderDetailsByOrderId(int orderId);
    }
}
