using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class CategoryObject
    {
      
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime CreatedAt { get; set; } = DateTime.Now;

            // Một danh mục có thể có nhiều sản phẩm
            public ICollection<ProductObject> Products { get; set; }
        
    }
}
