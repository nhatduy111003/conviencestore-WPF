using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderProductRepository
    {
        IEnumerable<OrderProductDAO> GetProductsByOrderId(int orderId);
        void AddOrderProduct(OrderProductDAO orderProduct);
        void DeleteOrderProduct(int orderId, int productId);
    }
}
