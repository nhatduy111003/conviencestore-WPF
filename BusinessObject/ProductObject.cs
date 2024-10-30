using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class ProductObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Khóa ngoại đến Category
        public int CategoryId { get; set; }
        public CategoryObject Category { get; set; }

        // Một sản phẩm có thể nằm trong nhiều Order
        public ICollection<OrderProductObject> OrderProducts { get; set; }
    }
}
