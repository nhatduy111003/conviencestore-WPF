using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderProductObject
    {
        public int OrderId { get; set; }
        public OrderObject Order { get; set; }

        public int ProductId { get; set; }
        public ProductObject Product { get; set; }

        public int Quantity { get; set; }
    }
}
