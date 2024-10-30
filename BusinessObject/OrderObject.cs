using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderObject
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserObject User { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Một đơn hàng có nhiều sản phẩm qua bảng trung gian OrderProduct
        public ICollection<OrderProductObject> OrderProducts { get; set; }
    }
}
