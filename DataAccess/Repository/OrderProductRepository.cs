using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderProductRepository : IOrderProductRepository
    {
        private readonly List<OrderProductDAO> _orderProducts = new List<OrderProductDAO>();

        public IEnumerable<OrderProductDAO> GetProductsByOrderId(int orderId)
        {
            return _orderProducts.Where(op => op.OrderId == orderId);
        }

        public void AddOrderProduct(OrderProductDAO orderProduct)
        {
            _orderProducts.Add(orderProduct);
        }

        public void DeleteOrderProduct(int orderId, int productId)
        {
            var orderProduct = _orderProducts.FirstOrDefault(op => op.OrderId == orderId && op.ProductId == productId);
            if (orderProduct != null)
            {
                _orderProducts.Remove(orderProduct);
            }
        }
    }
}
