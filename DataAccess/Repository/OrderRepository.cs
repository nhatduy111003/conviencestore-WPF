using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<OrderDAO> _orders = new List<OrderDAO>();

        public OrderDAO GetOrderById(int id)
        {
            return _orders.FirstOrDefault(order => order.Id == id);
        }

        public IEnumerable<OrderDAO> GetAllOrders()
        {
            return _orders;
        }

        public void AddOrder(OrderDAO order)
        {
            _orders.Add(order);
        }

        public void UpdateOrder(OrderDAO order)
        {
            var existingOrder = GetOrderById(order.Id);
            if (existingOrder != null)
            {
                existingOrder.UserId = order.UserId;
                existingOrder.TotalPrice = order.TotalPrice;
                existingOrder.Status = order.Status;
                existingOrder.CreatedAt = order.CreatedAt;
            }
        }

        public void DeleteOrder(int id)
        {
            var order = GetOrderById(id);
            if (order != null)
            {
                _orders.Remove(order);
            }
        }
    }
}
